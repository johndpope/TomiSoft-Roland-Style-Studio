using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

			moPiano.PianoKeyDown += (o, e) => {
				int Octave = e.Key / 12;
				int Key = e.Key % 12;

				this.nudOctave.Value = Octave;
				this.cbPitch.SelectedIndex = Key;
			};
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
