namespace TomiSoft_Style_Studio {
	partial class NoteEventEditDialog {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbTimeCPT = new System.Windows.Forms.TextBox();
			this.tbTimeBeat = new System.Windows.Forms.TextBox();
			this.tbTimeBar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbNoteLength = new System.Windows.Forms.ComboBox();
			this.btnInputFromDevice = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.cbPitch = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudOctave = new System.Windows.Forms.NumericUpDown();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.moPiano = new TomiSoft.MusicUI.MultiOctavePiano();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.nudVelocity = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudOctave)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudVelocity)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbTimeCPT);
			this.groupBox1.Controls.Add(this.tbTimeBeat);
			this.groupBox1.Controls.Add(this.tbTimeBar);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(105, 131);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Event time";
			// 
			// tbTimeCPT
			// 
			this.tbTimeCPT.Location = new System.Drawing.Point(44, 71);
			this.tbTimeCPT.Name = "tbTimeCPT";
			this.tbTimeCPT.Size = new System.Drawing.Size(46, 20);
			this.tbTimeCPT.TabIndex = 5;
			// 
			// tbTimeBeat
			// 
			this.tbTimeBeat.Location = new System.Drawing.Point(44, 45);
			this.tbTimeBeat.Name = "tbTimeBeat";
			this.tbTimeBeat.Size = new System.Drawing.Size(46, 20);
			this.tbTimeBeat.TabIndex = 4;
			// 
			// tbTimeBar
			// 
			this.tbTimeBar.Location = new System.Drawing.Point(44, 19);
			this.tbTimeBar.Name = "tbTimeBar";
			this.tbTimeBar.Size = new System.Drawing.Size(46, 20);
			this.tbTimeBar.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "CPT:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Beat:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bar:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.nudVelocity);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cbNoteLength);
			this.groupBox2.Controls.Add(this.btnInputFromDevice);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.cbPitch);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.nudOctave);
			this.groupBox2.Location = new System.Drawing.Point(123, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 131);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Event parameters";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 101);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Velocity:";
			// 
			// cbNoteLength
			// 
			this.cbNoteLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNoteLength.FormattingEnabled = true;
			this.cbNoteLength.Items.AddRange(new object[] {
            "1/1",
            "1/2",
            "1/4",
            "1/8",
            "1/16",
            "1/32",
            "1/64"});
			this.cbNoteLength.Location = new System.Drawing.Point(55, 71);
			this.cbNoteLength.Name = "cbNoteLength";
			this.cbNoteLength.Size = new System.Drawing.Size(57, 21);
			this.cbNoteLength.TabIndex = 7;
			// 
			// btnInputFromDevice
			// 
			this.btnInputFromDevice.Location = new System.Drawing.Point(135, 19);
			this.btnInputFromDevice.Name = "btnInputFromDevice";
			this.btnInputFromDevice.Size = new System.Drawing.Size(75, 49);
			this.btnInputFromDevice.TabIndex = 2;
			this.btnInputFromDevice.Text = "Input from MIDI device";
			this.btnInputFromDevice.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Length:";
			// 
			// cbPitch
			// 
			this.cbPitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPitch.FormattingEnabled = true;
			this.cbPitch.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
			this.cbPitch.Location = new System.Drawing.Point(55, 45);
			this.cbPitch.Name = "cbPitch";
			this.cbPitch.Size = new System.Drawing.Size(57, 21);
			this.cbPitch.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Pitch:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Octave:";
			// 
			// nudOctave
			// 
			this.nudOctave.Location = new System.Drawing.Point(55, 19);
			this.nudOctave.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudOctave.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
			this.nudOctave.Name = "nudOctave";
			this.nudOctave.Size = new System.Drawing.Size(57, 20);
			this.nudOctave.TabIndex = 3;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.Location = new System.Drawing.Point(572, 249);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(653, 249);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// moPiano
			// 
			this.moPiano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.moPiano.HoldSelection = false;
			this.moPiano.Location = new System.Drawing.Point(12, 171);
			this.moPiano.LowestOctave = 0;
			this.moPiano.Name = "moPiano";
			this.moPiano.Octaves = 8;
			this.moPiano.Size = new System.Drawing.Size(720, 69);
			this.moPiano.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 155);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(313, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "You may input the desired note by clicking on a key of this piano:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Location = new System.Drawing.Point(345, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(383, 131);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Help";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(371, 30);
			this.label9.TabIndex = 0;
			this.label9.Text = "If you have a MIDI controller (eg. a synthesizer) connected to your PC, you may c" +
    "lick \"Input from MIDI device\" to input the desired note.";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(371, 30);
			this.label10.TabIndex = 1;
			this.label10.Text = "\"Velocity\" with value 0 means that this note is muted. If \"Velocity\" value is 127" +
    ", the note will be played in fortissimo.";
			// 
			// nudVelocity
			// 
			this.nudVelocity.Location = new System.Drawing.Point(55, 98);
			this.nudVelocity.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
			this.nudVelocity.Name = "nudVelocity";
			this.nudVelocity.Size = new System.Drawing.Size(57, 20);
			this.nudVelocity.TabIndex = 8;
			this.nudVelocity.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
			// 
			// NoteEventEditDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(740, 284);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.moPiano);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NoteEventEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit note";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteEventEditDialog_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudOctave)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudVelocity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbTimeCPT;
		private System.Windows.Forms.TextBox tbTimeBeat;
		private System.Windows.Forms.TextBox tbTimeBar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbNoteLength;
		private System.Windows.Forms.Button btnInputFromDevice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbPitch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nudOctave;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label7;
		private TomiSoft.MusicUI.MultiOctavePiano moPiano;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nudVelocity;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
	}
}