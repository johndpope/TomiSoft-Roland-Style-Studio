using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Midi;

//using Sanford.Multimedia.Midi;

namespace TomiSoft_Style_Studio {
	class MidiOutputHandler : IDisposable {
		private static MidiOutputHandler Instance;

		public static void Initialize(int DeviceID) {
			if (MidiOutputHandler.Instance != null)
				throw new InvalidOperationException("Only one instance is allowed of MidiOutputHandler and it is already initialized.");

			MidiOutputHandler.Instance = new MidiOutputHandler(DeviceID);
		}

		public static MidiOutputHandler GetInstance() {
			return MidiOutputHandler.Instance;
		}

		public static void DisposeInstance() {
			MidiOutputHandler.Instance.Dispose();
		}

		private OutputDevice device;
		public OutputDevice Device {
			get {
				return this.device;
			}
		}

		private MidiOutputHandler(int DeviceID) {
			this.ReinitializeDevice(DeviceID);
		}

		public void ReinitializeDevice(int NewOutputDeviceID) {
			this.Dispose();

			try {
				this.device = OutputDevice.InstalledDevices[NewOutputDeviceID];
				this.device.Open();
			}
			catch {
				System.Windows.Forms.MessageBox.Show("Hiba a MIDI kimeneti eszköz inicializálásakor");
			}
		}

		public void Dispose() {
			if (this.device != null) {
				this.device.Close();
			}
		}

		public void SendQuickNoteOnMessage(int BankMSB, int BankLSB, int Program, int MidiChannel, int Note) {
			device.SendControlChange((Channel)MidiChannel, Control.DataEntryMSB, BankMSB);
			device.SendControlChange((Channel)MidiChannel, Control.DataEntryLSB, BankLSB);
			device.SendProgramChange((Channel)MidiChannel, (Instrument)Program);

			device.SendNoteOn((Channel)MidiChannel, (Pitch)Note, 127);

			//Device.Send(new ChannelMessage(ChannelCommand.Controller, MidiChannel, 0, BankMSB));
			//Device.Send(new ChannelMessage(ChannelCommand.Controller, MidiChannel, 32, BankLSB)); //Bank select
			//Device.Send(new ChannelMessage(ChannelCommand.ProgramChange, MidiChannel, Program, 0));

			//this.Device.Send(new ChannelMessage(ChannelCommand.NoteOn, 4, Note, 127));
		}

		public void SendQuickNoteOffMessage(int MidiChannel, int Note) {
			device.SendNoteOff((Channel)MidiChannel, (Pitch)Note, 0);
		}
	}
}
