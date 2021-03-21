
namespace TestApp
{
	partial class Form1
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
			this.eventLogger = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// eventLogger
			// 
			this.eventLogger.Location = new System.Drawing.Point(12, 12);
			this.eventLogger.Name = "eventLogger";
			this.eventLogger.Size = new System.Drawing.Size(491, 298);
			this.eventLogger.TabIndex = 0;
			this.eventLogger.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(515, 322);
			this.Controls.Add(this.eventLogger);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestApp";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox eventLogger;
	}
}

