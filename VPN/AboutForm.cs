using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace OpenVpnHelper
{
	public partial class AboutForm : Form
	{
		public AboutForm(string version)
		{
			InitializeComponent();
			versionLabel.Text += version;
		}

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://blog.naver.com/ko997ko/220627034985");
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
