using System;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary;

// 작업 목록
// TODO: Progress bar가 진행 상황에 따라 차기
// TODO: WatchProgress 살리기

namespace OpenVpnHelper
{
	// 메인 폼 클래스
	public partial class MainForm : Form
	{
		// 필드
		Process process;					// openvpn 프로세스 
		ProcessStartInfo processStartInfo;	// 프로세스 시작 정보
		RadioButton[] hiddenRadioButton;    // 추가될 라디오 버튼 배열
		AddOvpnFileForm addOvpnFileForm;	// ovpn 추가 폼
		SettingForm settingForm;			// ovpn 설정 폼
		OpenVpn openVpn;                    // openvpn 정보를 담고 있는 클래스
		BinaryFormatter bf;					// OpenVpn 객체 입출력에 사용
		bool radioButtonChecked = false;    // 라디오 버튼이 체크가 되지 않으면 시작불가
		bool vpnIsRunnig = false;           // 프로세스가 실행 중인지 판단
		const string version = "1.0.0";		// 버전
		const string programFilesPath = @"C:\Program Files\OpenVPN Helper\";
		//ProgressConsole pc;

		// 그냥 string enum 흉내
		class Status
		{
		    public static string Run = "VPN is runnig.";
			public static string Exit = "VPN is not runnig.";
		}

		// 생성자
		public MainForm()
		{
			InitializeComponent();
			process = new Process();
			processStartInfo = new ProcessStartInfo();
			process.StartInfo = processStartInfo;
			bf = new BinaryFormatter();
			hiddenRadioButton = new RadioButton[6] { hiddenRadioButton1, hiddenRadioButton2, hiddenRadioButton3, hiddenRadioButton4, hiddenRadioButton5, hiddenRadioButton6 };
		}

		// 메인폼 로드될 때
		private void mainForm_Load(object sender, EventArgs e)
		{
			#region 사라짐
			//using (BinaryReader br = new BinaryReader(File.OpenRead(ProgramFilesPath + "data.bin")))
			//{
			//	watchProgressToolStripMenuItem.Checked = br.ReadBoolean();
			//	Openvpn.Length = br.ReadInt32();
			//	if (Openvpn.Length > 2)
			//	{
			//		for (int i = 2; i < Openvpn.Length; i++)
			//		{
			//			Openvpn.OvpnName[i] = br.ReadString();
			//			Openvpn.OvpnPath[i] = br.ReadString();
			//		}
			//	}
			//}
			#endregion
			using (FileStream fs = File.OpenRead(Path.Combine(programFilesPath, "data.bin")))
			{
				openVpn = (OpenVpn)bf.Deserialize(fs);
			}

			for(int i = 2; i < openVpn.Length; i++)
			{
				//TODO:RadioButton 네이밍 하기
				hiddenRadioButton[i-2].Visible = true;
				hiddenRadioButton[i-2].Text = openVpn.OvpnInfo[i].Name;
			}
			
			this.StatusTimer.Start();
		}
		private void statusTimer_Tick(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("openvpn").Length == 0)
			{
				StatusLabel.Text = Status.Exit;
			}
			else
			{
				StatusLabel.Text = Status.Run;
			}
		}

		// 체크할 때
		private void radioButton_Checked(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;
			if (!rb.Checked) return;

			processStartInfo.WorkingDirectory = openVpn.WorkingDirectory;
			processStartInfo.FileName = openVpn.FileName;
			processStartInfo.Arguments = openVpn.GetArgument(Convert.ToInt32(rb.Tag));
			//if (watchProgressToolStripMenuItem.Checked)
			//{
			//	pc = new ProgressConsole();
			//	ps.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
			//	{
			//		try
			//		{
			//			pc.console.Invoke(new Action(() => { pc.console.Text += e.Data + "\r\n"; }));
			//		}
			//		catch (Exception ex)
			//		{
			//			MessageBox.Show(ex.Message);
			//		}
			//	});
			//	ps.EnableRaisingEvents = false;
			//}
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			radioButtonChecked = true;
		}

		// 시작 버튼 누를 때
		private void runButton_Click(object sender, EventArgs e)
		{
			if (!radioButtonChecked)
			{
				MessageBox.Show("Please check VPN!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Process.GetProcessesByName("openvpn").Length != 0)
			{
				return;
			}

			try	{ 
				process.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			ProgressBar.Visible = true;
			ProgressBar.Value = 0;
			ProgressTimer.Start();
			//if (watchProgressToolStripMenuItem.Checked)
			//{
			//	pc.Show();
			//	ps.BeginOutputReadLine();
			//	ps.Close();

			//}
			makeLogFile();
			//StatusLabel.Text = Status.Run;
		}
		private void progressTimer_Tick(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("openvpn").Length == 0)
			{
				ProgressBar.Visible = false;
				ProgressTimer.Stop();
			}

			if (ProgressBar.Value < ProgressBar.Maximum)
			{
				ProgressBar.Value += 1;
			}
			else
			{
				if (vpnIsRunnig)
				{
					ProgressBar.Visible = false;
					ProgressTimer.Stop();
				}
			}
		}
		private async void makeLogFile()
		{
			string diretory = Path.Combine(programFilesPath, "log");
			if(!Directory.Exists(diretory))
			{
				Directory.CreateDirectory(diretory);
			}

			using (StreamWriter logWriter = new StreamWriter(File.Create(Path.Combine(diretory, DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log")), Encoding.Default))
			{
				while (Process.GetProcessesByName("openvpn").Length != 0)
				{
					string temp = await process.StandardOutput.ReadLineAsync();
					await logWriter.WriteLineAsync(temp);
					if (temp.Contains("Initialization Sequence Completed"))
					{
						vpnIsRunnig = true;
					}
				}
			}
		}

		// 종료 버튼 누를 때
		private void exitButton_Click(object sender, EventArgs e)
		{
			foreach (Process p in Process.GetProcessesByName("openvpn"))
			{
				p.Kill();
			}
			StatusLabel.Text = Status.Exit;
		}

		// 작업 보기 선택 시
		private void watchProgressMenuItem_Click(object sender, EventArgs e)
		{
			//ToolStripMenuItem tsmi = sender as ToolStripMenuItem;

			//if (tsmi.Checked)
			//{
			//	tsmi.Checked = false;
			//}
			//else
			//{
			//	tsmi.Checked = true;
			//}
			MessageBox.Show("죄송합니다. 오류로 인해 중단합니다.");
		}
		
		// ovpn 파일 추가할 때
		private void addOvpnFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openVpn.Length == 8)
			{
				MessageBox.Show("더이상 추가가 불가능합니다!");
				return;
			}

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string name = "";
				string path;
				addOvpnFileForm = new AddOvpnFileForm();
				
				if(addOvpnFileForm.ShowDialog(ref name) == DialogResult.OK)
				{
					if (name.Equals(""))
					{
						name = "unknown";
					}

					//TODO: 수정하셈
					for(int i = 0; i < openVpn.Length; i++)
					{
						if (openVpn.OvpnInfo[i].Name.Equals(name))
						{
							name += "_";
						}
					}

					File.Copy(openFileDialog.FileName, path = Path.Combine(programFilesPath, "ovpn", name + ".ovpn"));
					openVpn.OvpnInfo[openVpn.Length].Name = name;
					openVpn.OvpnInfo[openVpn.Length].Path = path;
					hiddenRadioButton[openVpn.Length - 3].Visible = true;
					hiddenRadioButton[openVpn.Length - 3].Text = name;
				}
			}
		}

		// 종료하기 눌렀을 때
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// 도움말 눌렀을 때
		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("1. VPN을 고른다.\n2. 시작한다.\n3. 연결을 기다리면서 갓성우 삼창한다. (★중요★)\n4. 연결되면 마음껏 인터넷을 즐긴다^^", "간단명료 사용법 (이해 안가면 오랑우탄)");
		}

		// 정보 보기 눌렀을 때
		private void infoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm form = new AboutForm(version);
			form.Show();
		}

		// 끝나기 전에
		private void mainForm_Closing(object sender, FormClosingEventArgs e)
		{
			foreach (Process p in Process.GetProcessesByName("openvpn"))
			{
				p.Kill();
			}
			#region 사라짐
			//using (BinaryWriter bw = new BinaryWriter(File.Create(ProgramFilesPath + "data.bin")))
			//{
			//	bw.Write(watchProgressToolStripMenuItem.Checked);
			//	bw.Write(Openvpn.Length);
			//	if (Openvpn.Length > 2)
			//	{
			//		for (int i = 2; i < Openvpn.Length; i++)
			//		{
			//			bw.Write(Openvpn.OvpnName[i]);
			//			bw.Write(Openvpn.OvpnPath[i]);
			//		}
			//	}
			//}
			#endregion


			using (FileStream fs = File.OpenWrite(Path.Combine(programFilesPath, "data.bin")))
			{
				bf.Serialize(fs, openVpn);
			}
			
			StatusTimer.Stop();
		}

		private void openLogFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(Path.Combine(programFilesPath, "log"));
		}

		private void showLastedLogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileInfo[] fileinfo = new DirectoryInfo(Path.Combine(programFilesPath, "log")).GetFiles();
			Process.Start("notepad", fileinfo[fileinfo.Length - 1].FullName);

			//string[] files = Directory.GetFiles(Path.Combine(programFilesPath, "log"));
			//Process.Start("notepad", files[files.Length - 1]));
		}

		private void setOpenVpnFilesSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			settingForm = new SettingForm();
			settingForm.ShowDialog();
		}
	}
}
