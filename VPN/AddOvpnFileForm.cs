using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenVpnHelper
{
	public partial class AddOvpnFileForm : Form
	{
		public AddOvpnFileForm()
		{
			InitializeComponent();
		}
		
		public DialogResult ShowDialog(ref string text)
		{
			//TODO: 해야됨
			text = textBox.Text;
			return this.ShowDialog();
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			
		}
	}
}
