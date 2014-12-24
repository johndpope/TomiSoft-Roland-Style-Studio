using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TomiSoft.RolandStyleReader;

namespace TomiSoft_Style_Studio {
	public partial class ChordFamilySelector : UserControl {
		private ChordType chord = ChordType.Major;

		public ChordType SelectedChordType {
			get {
				return this.chord;
			}
		}

		public event EventHandler<ChordTypeEventArgs> ChordFamilyChanged;

		public ChordFamilySelector() {
			InitializeComponent();

			Dictionary<RadioButton, ChordType> Mappings = new Dictionary<RadioButton, ChordType>() {
				{radioButton1, ChordType.Major},
				{radioButton2, ChordType.Minor},
				{radioButton3, ChordType.Seventh}
			};

			foreach (var item in Mappings) {
				item.Key.CheckedChanged += (o, e) => {
					if (item.Key.Checked)
						this.OnChordChanged(item.Value);
				};
			}
		}

		private void OnChordChanged(ChordType t) {
			this.chord = t;
			if (this.ChordFamilyChanged != null) {
				this.ChordFamilyChanged(this, new ChordTypeEventArgs(t));
			}
		}
	}
}
