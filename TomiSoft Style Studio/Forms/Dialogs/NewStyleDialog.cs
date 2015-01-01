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
	public partial class frmNewStyle : Form {
		public string StyleName {
			get {
				return tbName.Text;
			}
		}

		private int tempo;
		public int Tempo {
			get {
				return tempo;
			}
		}

		public Measure Measure {
			get {
				string[] Parts = cbMeasure.Items[cbMeasure.SelectedIndex].ToString().Split('/');
				return new Measure(
					Convert.ToInt32(Parts[0]),
					Convert.ToInt32(Parts[1])
				);
			}
		}

		public StyleFileFormat Format {
			get {
				return (rb2Var.Checked) ? StyleFileFormat.Var2_STL : StyleFileFormat.Var4_STL;
			}
		}

		public frmNewStyle() {
			InitializeComponent();

			cbMeasure.Items.AddRange(new string[] {
				"1/2",
				"2/2",
				"2/4",
				"3/4",
				"4/4",
				"6/8",
			});
			cbMeasure.SelectedIndex = 4;

			nudTempo.ValueChanged += (o, e) => this.tempo = Convert.ToInt32(nudTempo.Value);

			nudTempo.Value = 100;
		}

		private void btnCreate_Click(object sender, EventArgs e) {
			if (this.Check()) {
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
		}

		private bool Check() {
			if (tbName.Text == String.Empty) {
				Error("You must give the style's name");
				return false;
			}
			else if (tbName.Text.Length >= 16) {
				Error("The style's name must be equal or less than 16 characters");
				return false;
			}

			return true;
		}

		private void Error(string Text) {
			MessageBox.Show(
				Text,
				"Error",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error
			);
		}

		private void rb2Var_CheckedChanged(object sender, EventArgs e) {
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		protected override void OnClosing(CancelEventArgs e) {
			if (this.DialogResult != DialogResult.OK)
				this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}
	}
}
