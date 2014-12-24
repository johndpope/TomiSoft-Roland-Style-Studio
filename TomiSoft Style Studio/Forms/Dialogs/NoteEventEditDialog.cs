using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomiSoft.MusicUI;
using TomiSoft.RolandStyleReader;

namespace TomiSoft_Style_Studio {
	public partial class NoteEventEditDialog : Form {
		
		public NoteEventEditDialog(Measure Measure) {
			InitializeComponent();
			
			btnOk.Click += (o, e) => {
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			};

			btnCancel.Click += (o, e) => {
				this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
				this.Close();
			};

			this.cbPitch.SelectedIndex = 0;
			this.cbNoteLength.SelectedIndex = 0;

			this.tbTimeBar.Text = "0";
			this.tbTimeBeat.Text = "0";
			this.tbTimeCPT.Text = "0";
			this.nudVelocity.Value = 127;

			moPiano.PianoKeyDown += PianoKeyDown;
			moPiano.PianoKeyUp += PianoKeyUp;
		}

		[HandleProcessCorruptedStateExceptionsAttribute]
		public void PianoKeyDown(object o, PianoEventArgs e) {
			int Octave = e.Key / 12;
			int Key = e.Key % 12;

			this.nudOctave.Value = Octave;
			this.cbPitch.SelectedIndex = Key;

			try {
				MidiOutputHandler.GetInstance().SendQuickNoteOnMessage(0, 0, 0, 4, e.Key);
			}
			catch (AccessViolationException) {
				MessageBox.Show(
					"Memory read/write error has occured.\n\n"+
					"You should save all your work because the application\n"+
					"is in an unsafe state and restart the software!\n\n"+
					"Reason: The MIDI playback subsystem has been crashed and could not be restarted.\n"+
					"Any MIDI output interaction will crash the entire software.\n\n"+
					"The application will not exit when you click the OK button.",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		[HandleProcessCorruptedStateExceptionsAttribute]
		public void PianoKeyUp(object o, PianoEventArgs e) {
			try {
				MidiOutputHandler.GetInstance().SendQuickNoteOffMessage(4, e.Key);
			}
			catch (AccessViolationException) {
				MessageBox.Show(
					"Memory read/write error has occured.\n\n" +
					"You should save all your work because the application\n" +
					"is in an unsafe state and restart the software!\n\n" +
					"Reason: The MIDI playback subsystem has been crashed.\n" +
					"Any MIDI output interaction will crash the entire software.",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		public NoteEventEditDialog(Measure Measure, NoteMessage msg) : this(Measure) {
			nudVelocity.Value = msg.Velocity;

			StyleTime t = StyleTime.FromStyleTimestamp(msg.TotalTime, Measure);

			this.tbTimeBar.Text = t.Bar.ToString();
			this.tbTimeBeat.Text = t.Beat.ToString();
			this.tbTimeCPT.Text = t.ClockPulseTime.ToString();
			this.nudVelocity.Value = msg.Velocity;
		}

		private void NoteEventEditDialog_FormClosing(object sender, FormClosingEventArgs e) {
			if (this.DialogResult == System.Windows.Forms.DialogResult.None)
				this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}
	}
}
