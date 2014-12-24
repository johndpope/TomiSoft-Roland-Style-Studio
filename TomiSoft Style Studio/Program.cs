using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TomiSoft_Style_Studio {
	public enum StartupStatus {
		InitMidiOutDevice, None
	}

	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			frmStartupScreen Startup = new frmStartupScreen();
			Startup.Show();

			Startup.Status = StartupStatus.InitMidiOutDevice;
			Properties.Settings s = new Properties.Settings();
			MidiOutputHandler.Initialize(s.MidiOutputDeviceID);
			Startup.Status = StartupStatus.None;

			Thread.Sleep(2000);
			Startup.Close();

			Application.Run(new frmMainWindow());

			MidiOutputHandler.DisposeInstance();
		}
	}
}
