using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TomiSoft.RolandStyleReader;
using Midi;

namespace TomiSoft_Style_Studio {
	public partial class MidiPlaybackDialog : Form {
		private MidiMessagePlayer Player;
		private Measure Measure;

		public MidiPlaybackDialog(Measure m, int Tempo, IEnumerable<StyleEntry> Messages) {
			InitializeComponent();

			this.Player = new MidiMessagePlayer(
				Tempo,
				MidiOutputHandler.GetInstance().Device,
				Messages
			);

			pbPosition.Maximum = Player.TotalTime;
			pbBeat.Maximum = m.Numerator;
			this.Measure = m;
		}

		public void Play() {
			do {
				Player.Play();

				while (Player.Position < Player.TotalTime / (480f / this.Measure.Denominator)) {
					StyleTime t = StyleTime.FromStyleTimestamp((int)(Player.Position * 120), this.Measure);
					pbBeat.Value = t.Beat;
					pbPosition.Value = (t.RawTime > pbPosition.Maximum) ? pbPosition.Maximum : t.RawTime;

					lMeasure.Text = String.Format("{0}/{1}", t.Beat, t.Bar);

					System.Threading.Thread.Sleep(50);
					Application.DoEvents();
				}

				Player.Stop();
				Player.Rewind();
			}
			while (cbLoop.Checked);

			this.Close();
		}
	}
}
