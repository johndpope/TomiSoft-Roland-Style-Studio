using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TomiSoft_Style_Studio {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Form Startup = new frmStartupScreen();
			Startup.Show();

			Thread.Sleep(2000);

			Startup.Close();

			Application.Run(new frmMainWindow());
		}
	}
}
