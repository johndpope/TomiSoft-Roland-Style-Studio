using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomiSoft_Style_Studio {
	public partial class frmStartupScreen : Form {
		private Dictionary<StartupStatus, string> StatusTexts = new Dictionary<StartupStatus, string>() {
			{StartupStatus.InitMidiOutDevice, "Connecting to MIDI output device..."},
			{StartupStatus.None, "Starting..."}
		};

		public StartupStatus Status {
			set {
				this.lStatus.Text = this.StatusTexts[value];
				this.Update();
			}
		}

		public frmStartupScreen() {
			InitializeComponent();
			this.Status = StartupStatus.None;
		}
	}
}
