using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomiSoft_Style_Studio {
	public partial class frmWelcome : Form {
		public event EventHandler CreateNewStyle;
		public event EventHandler OpenStyleFile;

		public frmWelcome() {
			InitializeComponent();

			btnCreateNew.Click += (o, e) => {
				this.Close();
				if (this.CreateNewStyle != null)
					this.CreateNewStyle(this, EventArgs.Empty);
			};

			btnOpenFile.Click += (o, e) => {
				this.Close();
				if (this.OpenStyleFile != null)
					this.OpenStyleFile(this, EventArgs.Empty);
			};
		}
	}
}
