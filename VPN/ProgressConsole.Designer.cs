namespace OpenVpnHelper
{
	partial class ProgressConsole
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
			this.console = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// console
			// 
			this.console.Location = new System.Drawing.Point(0, 0);
			this.console.Multiline = true;
			this.console.Name = "console";
			this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.console.Size = new System.Drawing.Size(985, 562);
			this.console.TabIndex = 0;
			// 
			// ProgressConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.console);
			this.Name = "ProgressConsole";
			this.Text = "ProgressConsole";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox console;
	}
}