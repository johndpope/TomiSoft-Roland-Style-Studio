namespace TomiSoft_Style_Studio {
	partial class frmStartupScreen {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartupScreen));
			this.lStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lStatus
			// 
			this.lStatus.AutoSize = true;
			this.lStatus.BackColor = System.Drawing.Color.Transparent;
			this.lStatus.ForeColor = System.Drawing.Color.White;
			this.lStatus.Location = new System.Drawing.Point(12, 475);
			this.lStatus.Name = "lStatus";
			this.lStatus.Size = new System.Drawing.Size(52, 13);
			this.lStatus.TabIndex = 0;
			this.lStatus.Text = "Starting...";
			// 
			// frmStartupScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(300, 500);
			this.Controls.Add(this.lStatus);
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmStartupScreen";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lStatus;
	}
}

