using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sanford.Multimedia.Midi;

namespace TomiSoft_Style_Studio {
	public partial class frmOptions : Form {
		public frmOptions() {
			InitializeComponent();

			for (int i = 0; i < OutputDevice.DeviceCount; i++) {
				MidiOutCaps Capabilities = OutputDevice.GetDeviceCapabilities(i);
				cbMidiOutputDevices.Items.Add(Capabilities.name);
			}

			for (int i = 0; i < InputDevice.DeviceCount; i++) {
				MidiInCaps Capabilities = InputDevice.GetDeviceCapabilities(i);
				cbMidiInputDevices.Items.Add(Capabilities.name);
			}

			if (cbMidiOutputDevices.Items.Count > 0)
				cbMidiOutputDevices.SelectedIndex = 0;

			if (cbMidiInputDevices.Items.Count > 0)
				cbMidiInputDevices.SelectedIndex = 0;
		}
	}
}
