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
	public partial class frm2VariationEditor : Form {
		private RolandStyleData Data;
		private StylePart SelectedPart = StylePart.Intro;
		private Arrangement SelectedArrangement = Arrangement.Basic;
		private Instrument SelectedInstrument = Instrument.Drum;
		private ChordType SelectedChordFamily = ChordType.Major;

		private Dictionary<RadioButton, StylePart> StylePartMappings;

		public frm2VariationEditor(string Filename) {
			InitializeComponent();

			this.Data = RolandStyleData.CreateFromReader(
				new Reader_STL_2var(Filename)
			);

			this.Text = this.Data.Name;

			this.Initialize();
		}

		public frm2VariationEditor(string Name, int Tempo, Measure Measure) {
			InitializeComponent();

			this.Data = new RolandStyleData(Name, Tempo, Measure);

			this.Text = Name;

			this.Initialize();
		}

		private void Initialize() {
			this.StylePartMappings = new Dictionary<RadioButton, StylePart>() {
				{rbPartIntro, StylePart.Intro},
				{rbPartOriginal, StylePart.Original},
				{rbPartVariation, StylePart.Variation},
				{rbPartFillToOriginal, StylePart.FillToOriginal},
				{rbPartFillToVariation, StylePart.FillToVariation},
				{rbPartEnding, StylePart.Ending}
			};

			this.isInstrument.InstrumentChanged += (o, e) => this.OnSelectedPartChanged();
			this.cfsChord.ChordFamilyChanged += (o, e) => this.OnSelectedPartChanged();

			this.rbArrangementBasic.CheckedChanged += (o, e) => this.OnSelectedPartChanged();
			this.rbArrangementAdvanced.CheckedChanged += (o, e) => this.OnSelectedPartChanged();

			foreach (var item in this.StylePartMappings) {
				item.Key.CheckedChanged += (o, e) => this.OnSelectedPartChanged();
			}

			this.lwMessages.ItemSelectionChanged += (o, e) => {
				if (lwMessages.SelectedIndices.Count == 1) {
					btnApplyMessageEdition.Text = "Apply changes";
					btnDeleteSelectedMessage.Enabled = true;
				}
				else {
					btnApplyMessageEdition.Text = "Add";
					btnDeleteSelectedMessage.Enabled = false;
				}
			};

			this.OnSelectedPartChanged();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void newStyleToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void openStyleToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void OnStyleLoaded() {
			miSave.Enabled = true;
			miSaveAs.Enabled = true;
		}

		private void OnSelectedPartChanged() {
			this.SelectedArrangement = rbArrangementBasic.Checked ? Arrangement.Basic : Arrangement.Advanced;

			this.SelectedPart = (from c in this.StylePartMappings
								 where c.Key.Checked
								 select c.Value).ElementAt(0);

			this.SelectedInstrument = isInstrument.SelectedInstrument;
			this.SelectedChordFamily = cfsChord.SelectedChordType;

			this.UpdateMidiEvents();
		}

		private void UpdateMidiEvents() {
			var Result = from c in this.Data.data
						 where
							c.Arrangement == this.SelectedArrangement &&
							c.ChordType == this.SelectedChordFamily &&
							c.Instrument == this.SelectedInstrument &&
							c.Part == this.SelectedPart
						 select c;

			lwMessages.Items.Clear();

			foreach (var item in Result) {
				ListViewItem lwi = new ListViewItem(StyleTime.FromStyleMessage(item.Message, this.Data).ToString());

				MidiMessage msg = item.Message;
				lwi.Tag = item;

				lwi.SubItems.Add(msg.MessageType.ToString());
				lwi.SubItems.Add(msg.Channel.ToString());

				switch (msg.MessageType) {
					case MidiMessageType.ControlChange:
						TomiSoft.RolandStyleReader.ControlChangeMessage ccm = (TomiSoft.RolandStyleReader.ControlChangeMessage)msg;
						lwi.SubItems.Add(ccm.Control.ToString());
						lwi.SubItems.Add(ccm.Value.ToString());
						break;

					case MidiMessageType.ProgramChange:
						TomiSoft.RolandStyleReader.ProgramChangeMessage pcm = (TomiSoft.RolandStyleReader.ProgramChangeMessage)msg;
						lwi.SubItems.Add(pcm.MSB.ToString());
						lwi.SubItems.Add(pcm.LSB.ToString());
						lwi.SubItems.Add(pcm.Program.ToString());
						break;

					case MidiMessageType.Note:
						TomiSoft.RolandStyleReader.NoteMessage nm = (TomiSoft.RolandStyleReader.NoteMessage)msg;
						lwi.SubItems.Add(nm.Name + " " + nm.Octave);
						lwi.SubItems.Add(nm.Velocity.ToString());
						lwi.SubItems.Add(nm.Length.ToString());
						break;
				}

				lwMessages.Items.Add(lwi);
			}
		}

		private void lwMessages_DoubleClick(object sender, EventArgs e) {
			if (lwMessages.SelectedIndices.Count == 1) {
				StyleEntry entry = (StyleEntry)lwMessages.SelectedItems[0].Tag;

				switch (entry.Message.MessageType) {
					case MidiMessageType.Note:
						NoteMessage msg = (NoteMessage)entry.Message;
						NoteEventEditDialog dlg = new NoteEventEditDialog(this.Data.Measure, msg);
						if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

						}
						break;
				}
			}
		}

		private void btnPlayInstrument_Click(object sender, EventArgs e) {
			var Result = from c in this.Data.data
						 where
							c.Arrangement == this.SelectedArrangement &&
							c.ChordType == this.SelectedChordFamily &&
							c.Instrument == this.SelectedInstrument &&
							c.Part == this.SelectedPart
						 select c;

			MidiPlaybackDialog dlg = new MidiPlaybackDialog(this.Data.Measure, this.Data.Tempo, Result);
			dlg.Show(this);
			dlg.Play();
		}
	}
}
