namespace OpenVpnHelper
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.iconPictureBox = new System.Windows.Forms.PictureBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.versionLabel = new System.Windows.Forms.Label();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.linkLabel = new System.Windows.Forms.LinkLabel();
			this.InfoLabel = new System.Windows.Forms.Label();
			this.nextToLinklabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// iconPictureBox
			// 
			this.iconPictureBox.BackgroundImage = global::OpenVpnHelper.Properties.Resources.icon;
			this.iconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.iconPictureBox.Location = new System.Drawing.Point(12, 12);
			this.iconPictureBox.Name = "iconPictureBox";
			this.iconPictureBox.Size = new System.Drawing.Size(50, 50);
			this.iconPictureBox.TabIndex = 0;
			this.iconPictureBox.TabStop = false;
			// 
			// pictureBox
			// 
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox.Location = new System.Drawing.Point(92, 29);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(75, 75);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// versionLabel
			// 
			this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(379, 50);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(32, 12);
			this.versionLabel.TabIndex = 1;
			this.versionLabel.Text = "Ver. ";
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Location = new System.Drawing.Point(246, 156);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(199, 12);
			this.copyrightLabel.TabIndex = 2;
			this.copyrightLabel.Text = "ⓒ 2016 전성우. All rights reserved.";
			// 
			// nameLabel
			// 
			this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.nameLabel.Location = new System.Drawing.Point(115, 25);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(222, 27);
			this.nameLabel.TabIndex = 3;
			this.nameLabel.Text = "OpenVPN Helper";
			// 
			// linkLabel
			// 
			this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel.AutoSize = true;
			this.linkLabel.Location = new System.Drawing.Point(155, 156);
			this.linkLabel.Name = "linkLabel";
			this.linkLabel.Size = new System.Drawing.Size(66, 12);
			this.linkLabel.TabIndex = 4;
			this.linkLabel.TabStop = true;
			this.linkLabel.Text = "Click here!";
			this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// InfoLabel
			// 
			this.InfoLabel.AutoSize = true;
			this.InfoLabel.Location = new System.Drawing.Point(10, 80);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new System.Drawing.Size(404, 60);
			this.InfoLabel.TabIndex = 5;
			this.InfoLabel.Text = "이 프로그램은 교육청 서버를 이용하여 각종 제제를 받아 고통받는\r\n\r\n대덕소프트웨어마이스터고등학교 학생들을 위해 제작되었습니다!\r\n\r\nOpenVP" +
    "N을 쉽게 사용하는 도우미 프로그램이니 많이 많이 사용해주세요!";
			// 
			// nextToLinklabel
			// 
			this.nextToLinklabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.nextToLinklabel.AutoSize = true;
			this.nextToLinklabel.Location = new System.Drawing.Point(12, 156);
			this.nextToLinklabel.Name = "nextToLinklabel";
			this.nextToLinklabel.Size = new System.Drawing.Size(137, 12);
			this.nextToLinklabel.TabIndex = 6;
			this.nextToLinklabel.Text = "더 많은 정보를 원한다면";
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(370, 199);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "확인";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(457, 234);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.nextToLinklabel);
			this.Controls.Add(this.InfoLabel);
			this.Controls.Add(this.linkLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.iconPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.Text = "About Openvpn Helper";
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox iconPictureBox;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label copyrightLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.LinkLabel linkLabel;
		private System.Windows.Forms.Label InfoLabel;
		private System.Windows.Forms.Label nextToLinklabel;
		private System.Windows.Forms.Button okButton;
	}
}