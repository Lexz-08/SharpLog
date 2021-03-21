using SharpLog;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			MouseDown += (sender, e) =>
			{
				eventLogger.Text += Logger.LogEvent_IncludeTime("TestApp", "MouseDown") + "\n";
			};
			MouseUp += (sender, e) =>
			{
				eventLogger.Text += Logger.LogEvent_IncludeTime("TestApp", "MouseUp") + "\n";
			};
			MouseEnter += (sender, e) =>
			{
				eventLogger.Text += Logger.LogEvent_IncludeTime("TestApp", "MouseEnter") + "\n";
			};
			MouseLeave += (sender, e) =>
			{
				eventLogger.Text += Logger.LogEvent_IncludeTime("TestApp", "MouseLeave") + "\n";
			};
		}
	}
}
