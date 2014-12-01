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
	public partial class frmMainWindow : Form {
		public frmMainWindow() {
			InitializeComponent();

			frmWelcome welcome = new frmWelcome();
			welcome.MdiParent = this;
			welcome.CreateNewStyle += (o, e) => this.CreateNewStyle();
			welcome.OpenStyleFile += (o, e) => this.OpenStyle();
			welcome.Show();
		}

		private void newStyleToolStripMenuItem_Click(object sender, EventArgs e) {
			this.CreateNewStyle();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void openStyleToolStripMenuItem_Click(object sender, EventArgs e) {
			this.OpenStyle();
		}

		private void OpenStyle() {
			OpenFileDialog dlg = new OpenFileDialog() {
				Filter = "Roland styles (*.stl, *.sth)|*.stl;*.sth"
			};

			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				Form frmEditor = new frm2VariationEditor(dlg.FileName);
				frmEditor.MdiParent = this;
				frmEditor.WindowState = FormWindowState.Maximized;
				frmEditor.Show();
			}
		}

		private void CreateNewStyle() {
			frmNewStyle dlg = new frmNewStyle();
			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				if (dlg.Format == StyleFileFormat.Var2_STL) {
					frm2VariationEditor frm = new frm2VariationEditor(dlg.StyleName, dlg.Tempo, dlg.Measure);
					frm.MdiParent = this;
					frm.WindowState = FormWindowState.Maximized;
					frm.Show();
				}
			}
		}

		private void miAbout_Click(object sender, EventArgs e) {
			using (Form dlg = new frmAbout()) {
				dlg.ShowDialog(this);
			}
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
			Form dlg = new frmOptions();
			dlg.ShowDialog(this);
		}
	}
}
