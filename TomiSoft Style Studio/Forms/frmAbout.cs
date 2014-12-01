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
	public partial class frmAbout : Form {
		public frmAbout() {
			InitializeComponent();

			this.lVersion.Text = String.Format("Version: {0}", Application.ProductVersion);
			this.lLibraryUrl.Click += (o, e) => System.Diagnostics.Process.Start(lLibraryUrl.Text);
		}
	}
}
