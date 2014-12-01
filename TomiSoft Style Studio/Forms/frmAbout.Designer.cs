namespace TomiSoft_Style_Studio {
	partial class frmAbout {
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lVersion = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lLibraryUrl = new System.Windows.Forms.LinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TomiSoft";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Roland Style Studio";
			// 
			// lVersion
			// 
			this.lVersion.ForeColor = System.Drawing.Color.Gray;
			this.lVersion.Location = new System.Drawing.Point(16, 42);
			this.lVersion.Name = "lVersion";
			this.lVersion.Size = new System.Drawing.Size(145, 17);
			this.lVersion.TabIndex = 2;
			this.lVersion.Text = "Version: 0.0.0.0";
			this.lVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 54);
			this.label3.TabIndex = 3;
			this.label3.Text = "This is a free software. Because of this the author of this software can not take" +
    " any responsibilites for any damage and data loss caused by this software. Use i" +
    "t for your own risk.";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(260, 41);
			this.label4.TabIndex = 4;
			this.label4.Text = "This software uses the TomiSoft Roland Style Reader library. For more information" +
    ", please visit the following repository:";
			// 
			// lLibraryUrl
			// 
			this.lLibraryUrl.AutoSize = true;
			this.lLibraryUrl.Location = new System.Drawing.Point(12, 187);
			this.lLibraryUrl.Name = "lLibraryUrl";
			this.lLibraryUrl.Size = new System.Drawing.Size(223, 13);
			this.lLibraryUrl.TabIndex = 5;
			this.lLibraryUrl.TabStop = true;
			this.lLibraryUrl.Text = "https://github.com/std66/RolandStyleReader";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(260, 29);
			this.label5.TabIndex = 6;
			this.label5.Text = "Roland name and Roland logo are registered trademarks of Roland Corporation.";
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 258);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lLibraryUrl);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lVersion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lVersion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel lLibraryUrl;
		private System.Windows.Forms.Label label5;
	}
}