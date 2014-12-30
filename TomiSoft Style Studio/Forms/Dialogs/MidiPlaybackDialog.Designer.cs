namespace TomiSoft_Style_Studio {
	partial class MidiPlaybackDialog {
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
			this.lMeasure = new System.Windows.Forms.Label();
			this.pbPosition = new TomiSoft_Style_Studio.CustomProgressBar();
			this.pbBeat = new TomiSoft_Style_Studio.CustomProgressBar();
			this.cbLoop = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lMeasure
			// 
			this.lMeasure.AutoSize = true;
			this.lMeasure.Location = new System.Drawing.Point(91, 34);
			this.lMeasure.Name = "lMeasure";
			this.lMeasure.Size = new System.Drawing.Size(24, 13);
			this.lMeasure.TabIndex = 4;
			this.lMeasure.Text = "0/0";
			// 
			// pbPosition
			// 
			this.pbPosition.BackColor = System.Drawing.Color.White;
			this.pbPosition.ForeColor = System.Drawing.Color.Green;
			this.pbPosition.Location = new System.Drawing.Point(12, 10);
			this.pbPosition.Maximum = 100;
			this.pbPosition.Minimum = 0;
			this.pbPosition.Name = "pbPosition";
			this.pbPosition.Size = new System.Drawing.Size(345, 15);
			this.pbPosition.TabIndex = 6;
			this.pbPosition.Value = 0;
			// 
			// pbBeat
			// 
			this.pbBeat.BackColor = System.Drawing.Color.White;
			this.pbBeat.ForeColor = System.Drawing.Color.Green;
			this.pbBeat.Location = new System.Drawing.Point(12, 36);
			this.pbBeat.Maximum = 100;
			this.pbBeat.Minimum = 0;
			this.pbBeat.Name = "pbBeat";
			this.pbBeat.Size = new System.Drawing.Size(73, 10);
			this.pbBeat.TabIndex = 5;
			this.pbBeat.Value = 0;
			// 
			// cbLoop
			// 
			this.cbLoop.AutoSize = true;
			this.cbLoop.Location = new System.Drawing.Point(307, 33);
			this.cbLoop.Name = "cbLoop";
			this.cbLoop.Size = new System.Drawing.Size(50, 17);
			this.cbLoop.TabIndex = 7;
			this.cbLoop.Text = "Loop";
			this.cbLoop.UseVisualStyleBackColor = true;
			// 
			// MidiPlaybackDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 60);
			this.ControlBox = false;
			this.Controls.Add(this.cbLoop);
			this.Controls.Add(this.pbPosition);
			this.Controls.Add(this.pbBeat);
			this.Controls.Add(this.lMeasure);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MidiPlaybackDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TomiSoft Style Player";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lMeasure;
		private CustomProgressBar pbBeat;
		private CustomProgressBar pbPosition;
		private System.Windows.Forms.CheckBox cbLoop;

	}
}