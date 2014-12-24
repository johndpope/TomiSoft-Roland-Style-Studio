using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Midi;

namespace TomiSoft_Style_Studio {
	public partial class frmOptions : Form {
		Properties.Settings Config;

		public frmOptions() {
			InitializeComponent();

			this.Config = new Properties.Settings();

			#region Initialize MIDI device checkboxes
			for (int i = 0; i < OutputDevice.InstalledDevices.Count; i++) {
				cbMidiOutputDevices.Items.Add(OutputDevice.InstalledDevices[i].Name);
			}

			for (int i = 0; i < InputDevice.InstalledDevices.Count; i++) {
				cbMidiInputDevices.Items.Add(InputDevice.InstalledDevices[i].Name);
			}

			if (cbMidiOutputDevices.Items.Count > 0)
				cbMidiOutputDevices.SelectedIndex = (OutputDevice.InstalledDevices.Count >= this.Config.MidiOutputDeviceID) ? this.Config.MidiOutputDeviceID : 0;

			if (cbMidiInputDevices.Items.Count > 0)
				cbMidiInputDevices.SelectedIndex = (InputDevice.InstalledDevices.Count >= this.Config.MidiInputDeviceID) ? this.Config.MidiInputDeviceID : 0;

			cbMidiOutputDevices.SelectedIndexChanged += (o, e) => this.Config.MidiOutputDeviceID = cbMidiOutputDevices.SelectedIndex;
			cbMidiInputDevices.SelectedIndexChanged += (o, e) => this.Config.MidiInputDeviceID = cbMidiInputDevices.SelectedIndex;
			#endregion
		}

		private void btnOk_Click(object sender, EventArgs e) {
			this.Config.Save();

			MidiOutputHandler.GetInstance().ReinitializeDevice(this.Config.MidiOutputDeviceID);

			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Config.Reload();
			this.Close();
		}
	}
}
