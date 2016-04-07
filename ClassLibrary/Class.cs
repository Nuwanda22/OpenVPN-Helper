using System;
using System.Text;

namespace ClassLibrary
{
	[Serializable]
	public class OvpnInfo
	{
		public string Name { get; set; }
		public string Path { get; set; }

		public OvpnInfo(string Name, string Path)
		{
			this.Name = Name;
			this.Path = Path;
		}

		public override string ToString()
		{
			return Name + "\t" + Path;
		}
	}

	[Serializable]
	public class OpenVpn
	{
		// 필드
		private OvpnInfo[] ovpnInfo = new OvpnInfo[8];
		private string workingDirectory;
		private string fileName;

		// 프로퍼티
		public int Length
		{
			get
			{
				int count = 0;
				foreach (OvpnInfo ovpn in ovpnInfo)
				{
					if (ovpn.Name == null || ovpn.Path == null)
					{
						break;
					}
					count++;
				}

				return count;
			}
		}
		public OvpnInfo[] OvpnInfo { get { return ovpnInfo; } }
		public string WorkingDirectory { get { return workingDirectory; } set { workingDirectory = value; } }
		public string FileName { get { return fileName; } set { fileName = value; } }

		// 생성자
		public OpenVpn()
		{
			workingDirectory = @"C:\Program Files\OpenVPN\bin";
			fileName = "openvpn.exe";

			ovpnInfo[0] = new OvpnInfo("Korea", @"C:\Program Files\OpenVPN Helper\ovpn\korea.ovpn");
			ovpnInfo[1] = new OvpnInfo("Japan", @"C:\Program Files\OpenVPN Helper\ovpn\japan.ovpn");
			for (int i = 2; i < ovpnInfo.Length; i++)
			{
				ovpnInfo[i] = new OvpnInfo(null, null);
			}
		}
		public OpenVpn(string path, string name)
		{
			workingDirectory = path;
			fileName = name;

			ovpnInfo[0] = new OvpnInfo("Korea", @"C:\Program Files\OpenVPN Helper\ovpn\korea.ovpn");
			ovpnInfo[1] = new OvpnInfo("Japan", @"C:\Program Files\OpenVPN Helper\ovpn\japan.ovpn");
			for (int i = 2; i < ovpnInfo.Length; i++)
			{
				ovpnInfo[i] = new OvpnInfo(null, null);
			}
		}
		public OpenVpn(params OvpnInfo[] ovpnInfo)
		{
			workingDirectory = @"C:\Program Files\OpenVPN\bin";
			fileName = "openvpn.exe";

			for (int i = 0; i < this.ovpnInfo.Length; i++)
			{
				this.ovpnInfo[i] = new OvpnInfo(ovpnInfo[i].Name, ovpnInfo[i].Path);
			}
		}
		public OpenVpn(string path, string name, params OvpnInfo[] ovpnInfo)
		{
			workingDirectory = path;
			fileName = name;

			for (int i = 0; i < this.ovpnInfo.Length; i++)
			{
				this.ovpnInfo[i] = new OvpnInfo(ovpnInfo[i].Name, ovpnInfo[i].Path);
			}
		}

		// 메소드
		public string GetArgument(int index)
		{
			return "\"" + ovpnInfo[index].Path + "\"";
		}
		public override string ToString()
		{
            StringBuilder temp = new StringBuilder();
            temp.AppendFormat("Length = {0}, Path = {1}\\{2}\n\n", Length, WorkingDirectory, FileName);
            temp.AppendLine("Openvpn List");
            foreach (OvpnInfo ovpn in ovpnInfo)
            {
				if (ovpn.Name == null || ovpn.Path == null)
				{
					break;
				}
				temp.AppendLine(ovpn.ToString());
            }
            return temp.ToString();
		}
	}
}
