namespace OpenVpnHelper
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.RunButton = new System.Windows.Forms.Button();
			this.koreaRadioButton = new System.Windows.Forms.RadioButton();
			this.RadioGroup = new System.Windows.Forms.GroupBox();
			this.hiddenRadioButton6 = new System.Windows.Forms.RadioButton();
			this.hiddenRadioButton5 = new System.Windows.Forms.RadioButton();
			this.hiddenRadioButton4 = new System.Windows.Forms.RadioButton();
			this.hiddenRadioButton3 = new System.Windows.Forms.RadioButton();
			this.hiddenRadioButton2 = new System.Windows.Forms.RadioButton();
			this.hiddenRadioButton1 = new System.Windows.Forms.RadioButton();
			this.japanRadioButton = new System.Windows.Forms.RadioButton();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.Label = new System.Windows.Forms.Label();
			this.ExitButton = new System.Windows.Forms.Button();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addOpenVpnFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setOpenVpnFilesSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openLogFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showLastedLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.watchProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusTimer = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.RadioGroup.SuspendLayout();
			this.MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// RunButton
			// 
			this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.RunButton.Location = new System.Drawing.Point(216, 151);
			this.RunButton.Name = "RunButton";
			this.RunButton.Size = new System.Drawing.Size(75, 23);
			this.RunButton.TabIndex = 1;
			this.RunButton.Text = "Start VPN";
			this.RunButton.UseVisualStyleBackColor = true;
			this.RunButton.Click += new System.EventHandler(this.runButton_Click);
			// 
			// koreaRadioButton
			// 
			this.koreaRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.koreaRadioButton.AutoSize = true;
			this.koreaRadioButton.Location = new System.Drawing.Point(17, 20);
			this.koreaRadioButton.Name = "koreaRadioButton";
			this.koreaRadioButton.Size = new System.Drawing.Size(56, 16);
			this.koreaRadioButton.TabIndex = 0;
			this.koreaRadioButton.TabStop = true;
			this.koreaRadioButton.Tag = "0";
			this.koreaRadioButton.Text = "Korea";
			this.koreaRadioButton.UseVisualStyleBackColor = true;
			this.koreaRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// RadioGroup
			// 
			this.RadioGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RadioGroup.Controls.Add(this.hiddenRadioButton6);
			this.RadioGroup.Controls.Add(this.hiddenRadioButton5);
			this.RadioGroup.Controls.Add(this.hiddenRadioButton4);
			this.RadioGroup.Controls.Add(this.hiddenRadioButton3);
			this.RadioGroup.Controls.Add(this.hiddenRadioButton2);
			this.RadioGroup.Controls.Add(this.hiddenRadioButton1);
			this.RadioGroup.Controls.Add(this.japanRadioButton);
			this.RadioGroup.Controls.Add(this.koreaRadioButton);
			this.RadioGroup.Location = new System.Drawing.Point(12, 37);
			this.RadioGroup.Name = "RadioGroup";
			this.RadioGroup.Size = new System.Drawing.Size(360, 108);
			this.RadioGroup.TabIndex = 2;
			this.RadioGroup.TabStop = false;
			this.RadioGroup.Text = "VPN";
			// 
			// hiddenRadioButton6
			// 
			this.hiddenRadioButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hiddenRadioButton6.AutoSize = true;
			this.hiddenRadioButton6.Location = new System.Drawing.Point(204, 86);
			this.hiddenRadioButton6.Name = "hiddenRadioButton6";
			this.hiddenRadioButton6.Size = new System.Drawing.Size(90, 16);
			this.hiddenRadioButton6.TabIndex = 7;
			this.hiddenRadioButton6.TabStop = true;
			this.hiddenRadioButton6.Tag = "7";
			this.hiddenRadioButton6.Text = "RadioButton";
			this.hiddenRadioButton6.UseVisualStyleBackColor = true;
			this.hiddenRadioButton6.Visible = false;
			this.hiddenRadioButton6.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// hiddenRadioButton5
			// 
			this.hiddenRadioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.hiddenRadioButton5.AutoSize = true;
			this.hiddenRadioButton5.Location = new System.Drawing.Point(17, 86);
			this.hiddenRadioButton5.Name = "hiddenRadioButton5";
			this.hiddenRadioButton5.Size = new System.Drawing.Size(90, 16);
			this.hiddenRadioButton5.TabIndex = 6;
			this.hiddenRadioButton5.TabStop = true;
			this.hiddenRadioButton5.Tag = "6";
			this.hiddenRadioButton5.Text = "RadioButton";
			this.hiddenRadioButton5.UseVisualStyleBackColor = true;
			this.hiddenRadioButton5.Visible = false;
			this.hiddenRadioButton5.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// hiddenRadioButton4
			// 
			this.hiddenRadioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hiddenRadioButton4.AutoSize = true;
			this.hiddenRadioButton4.Location = new System.Drawing.Point(204, 64);
			this.hiddenRadioButton4.Name = "hiddenRadioButton4";
			this.hiddenRadioButton4.Size = new System.Drawing.Size(90, 16);
			this.hiddenRadioButton4.TabIndex = 5;
			this.hiddenRadioButton4.TabStop = true;
			this.hiddenRadioButton4.Tag = "5";
			this.hiddenRadioButton4.Text = "RadioButton";
			this.hiddenRadioButton4.UseVisualStyleBackColor = true;
			this.hiddenRadioButton4.Visible = false;
			this.hiddenRadioButton4.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// hiddenRadioButton3
			// 
			this.hiddenRadioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.hiddenRadioButton3.AutoSize = true;
			this.hiddenRadioButton3.Location = new System.Drawing.Point(17, 64);
			this.hiddenRadioButton3.Name = "hiddenRadioButton3";
			this.hiddenRadioButton3.Size = new System.Drawing.Size(90, 16);
			this.hiddenRadioButton3.TabIndex = 4;
			this.hiddenRadioButton3.TabStop = true;
			this.hiddenRadioButton3.Tag = "4";
			this.hiddenRadioButton3.Text = "RadioButton";
			this.hiddenRadioButton3.UseVisualStyleBackColor = true;
			this.hiddenRadioButton3.Visible = false;
			this.hiddenRadioButton3.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// hiddenRadioButton2
			// 
			this.hiddenRadioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hiddenRadioButton2.AutoSize = true;
			this.hiddenRadioButton2.Location = new System.Drawing.Point(204, 42);
			this.hiddenRadioButton2.Name = "hiddenRadioButton2";
			this.hiddenRadioButton2.Size = new System.Drawing.Size(90, 16);
			this.hiddenRadioButton2.TabIndex = 3;
			this.hiddenRadioButton2.TabStop = true;
			this.hiddenRadioButton2.Tag = "3";
			this.hiddenRadioButton2.Text = "RadioButton";
			this.hiddenRadioButton2.UseVisualStyleBackColor = true;
			this.hiddenRadioButton2.Visible = false;
			this.hiddenRadioButton2.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// hiddenRadioButton1
			// 
			this.hiddenRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.hiddenRadioButton1.AutoSize = true;
			this.hiddenRadioButton1.Location = new System.Drawing.Point(17, 42);
			this.hiddenRadioButton1.Name = "hiddenRadioButton1";
			this.hiddenRadioButton1.Size = new System.Drawing.Size(90, 16);
			this.hiddenRadioButton1.TabIndex = 2;
			this.hiddenRadioButton1.TabStop = true;
			this.hiddenRadioButton1.Tag = "2";
			this.hiddenRadioButton1.Text = "RadioButton";
			this.hiddenRadioButton1.UseVisualStyleBackColor = true;
			this.hiddenRadioButton1.Visible = false;
			this.hiddenRadioButton1.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// japanRadioButton
			// 
			this.japanRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.japanRadioButton.AutoSize = true;
			this.japanRadioButton.Location = new System.Drawing.Point(204, 20);
			this.japanRadioButton.Name = "japanRadioButton";
			this.japanRadioButton.Size = new System.Drawing.Size(57, 16);
			this.japanRadioButton.TabIndex = 1;
			this.japanRadioButton.TabStop = true;
			this.japanRadioButton.Tag = "1";
			this.japanRadioButton.Text = "Japan";
			this.japanRadioButton.UseVisualStyleBackColor = true;
			this.japanRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_Checked);
			// 
			// StatusLabel
			// 
			this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Location = new System.Drawing.Point(59, 156);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(108, 12);
			this.StatusLabel.TabIndex = 3;
			this.StatusLabel.Text = "VPN is not runnig.";
			// 
			// Label
			// 
			this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Label.AutoSize = true;
			this.Label.Location = new System.Drawing.Point(12, 156);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(48, 12);
			this.Label.TabIndex = 4;
			this.Label.Text = "Status :";
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.Location = new System.Drawing.Point(297, 151);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "Exit VPN";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ProgressBar.Location = new System.Drawing.Point(61, 151);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(149, 23);
			this.ProgressBar.TabIndex = 6;
			this.ProgressBar.Visible = false;
			// 
			// ProgressTimer
			// 
			this.ProgressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
			// 
			// MenuStrip
			// 
			this.MenuStrip.BackColor = System.Drawing.SystemColors.Window;
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpHToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(384, 24);
			this.MenuStrip.TabIndex = 7;
			this.MenuStrip.Text = "menuStrip1";
			// 
			// fileFToolStripMenuItem
			// 
			this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOpenVpnFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
			this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.fileFToolStripMenuItem.Text = "File(&F)";
			// 
			// addOpenVpnFileToolStripMenuItem
			// 
			this.addOpenVpnFileToolStripMenuItem.Name = "addOpenVpnFileToolStripMenuItem";
			this.addOpenVpnFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.addOpenVpnFileToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.addOpenVpnFileToolStripMenuItem.Text = "Add OpenVPN File(&A)";
			this.addOpenVpnFileToolStripMenuItem.Click += new System.EventHandler(this.addOvpnFileToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.exitToolStripMenuItem.Text = "Exit(&X)";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setOpenVpnFilesSToolStripMenuItem,
            this.toolStripSeparator3,
            this.logToolStripMenuItem,
            this.watchProgressToolStripMenuItem});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.settingToolStripMenuItem.Text = "Setting(&S)";
			// 
			// setOpenVpnFilesSToolStripMenuItem
			// 
			this.setOpenVpnFilesSToolStripMenuItem.Name = "setOpenVpnFilesSToolStripMenuItem";
			this.setOpenVpnFilesSToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.setOpenVpnFilesSToolStripMenuItem.Text = "Set OpenVPN Files(&S)";
			this.setOpenVpnFilesSToolStripMenuItem.Click += new System.EventHandler(this.setOpenVpnFilesSToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
			// 
			// logToolStripMenuItem
			// 
			this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogFolderToolStripMenuItem,
            this.showLastedLogToolStripMenuItem});
			this.logToolStripMenuItem.Name = "logToolStripMenuItem";
			this.logToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.logToolStripMenuItem.Text = "Log";
			// 
			// openLogFolderToolStripMenuItem
			// 
			this.openLogFolderToolStripMenuItem.Name = "openLogFolderToolStripMenuItem";
			this.openLogFolderToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.openLogFolderToolStripMenuItem.Text = "Open Log Folder";
			this.openLogFolderToolStripMenuItem.Click += new System.EventHandler(this.openLogFolderToolStripMenuItem_Click);
			// 
			// showLastedLogToolStripMenuItem
			// 
			this.showLastedLogToolStripMenuItem.Name = "showLastedLogToolStripMenuItem";
			this.showLastedLogToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.showLastedLogToolStripMenuItem.Text = "Show Lasted Log";
			this.showLastedLogToolStripMenuItem.Click += new System.EventHandler(this.showLastedLogToolStripMenuItem_Click);
			// 
			// watchProgressToolStripMenuItem
			// 
			this.watchProgressToolStripMenuItem.Enabled = false;
			this.watchProgressToolStripMenuItem.Name = "watchProgressToolStripMenuItem";
			this.watchProgressToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.watchProgressToolStripMenuItem.Text = "Watch Progress(&W)";
			this.watchProgressToolStripMenuItem.Click += new System.EventHandler(this.watchProgressMenuItem_Click);
			// 
			// helpHToolStripMenuItem
			// 
			this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
			this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
			this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.helpHToolStripMenuItem.Text = "Help(&H)";
			// 
			// helpTopicsToolStripMenuItem
			// 
			this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
			this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.helpTopicsToolStripMenuItem.Text = "Help Topics(&H)";
			this.helpTopicsToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.aboutToolStripMenuItem.Text = "About OpenVPN Helper(&A)";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
			// 
			// StatusTimer
			// 
			this.StatusTimer.Interval = 1000;
			this.StatusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "openVPN Files|*.ovpn|All Files|*.*";
			this.openFileDialog.InitialDirectory = "C:\\Program Files\\OpenVPN\\bin";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(384, 186);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.Label);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.RadioGroup);
			this.Controls.Add(this.RunButton);
			this.Controls.Add(this.MenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainForm";
			this.Text = "OpenVPN Helper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_Closing);
			this.Load += new System.EventHandler(this.mainForm_Load);
			this.RadioGroup.ResumeLayout(false);
			this.RadioGroup.PerformLayout();
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button RunButton;
		private System.Windows.Forms.RadioButton koreaRadioButton;
		private System.Windows.Forms.GroupBox RadioGroup;
		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.Label Label;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Timer ProgressTimer;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addOpenVpnFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem watchProgressToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpTopicsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Timer StatusTimer;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.RadioButton hiddenRadioButton6;
		private System.Windows.Forms.RadioButton hiddenRadioButton5;
		private System.Windows.Forms.RadioButton hiddenRadioButton4;
		private System.Windows.Forms.RadioButton hiddenRadioButton3;
		private System.Windows.Forms.RadioButton hiddenRadioButton2;
		private System.Windows.Forms.RadioButton hiddenRadioButton1;
		private System.Windows.Forms.RadioButton japanRadioButton;
		private System.Windows.Forms.ToolStripMenuItem setOpenVpnFilesSToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openLogFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showLastedLogToolStripMenuItem;
	}
}

