namespace TomiSoft_Style_Studio {
	partial class frmNewStyle {
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
			this.cbMeasure = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rb4Var = new System.Windows.Forms.RadioButton();
			this.rb2Var = new System.Windows.Forms.RadioButton();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.nudTempo = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudTempo);
			this.groupBox1.Controls.Add(this.cbMeasure);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(418, 82);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General style properties";
			// 
			// cbMeasure
			// 
			this.cbMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMeasure.Location = new System.Drawing.Point(346, 19);
			this.cbMeasure.Name = "cbMeasure";
			this.cbMeasure.Size = new System.Drawing.Size(66, 21);
			this.cbMeasure.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(251, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Metronome mark:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(148, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "BPM";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tempo:";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(74, 19);
			this.tbName.MaxLength = 16;
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(100, 20);
			this.tbName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Style name:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.rb4Var);
			this.groupBox2.Controls.Add(this.rb2Var);
			this.groupBox2.Location = new System.Drawing.Point(12, 100);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(418, 84);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "File format";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "My Roland keyboard has:";
			// 
			// rb4Var
			// 
			this.rb4Var.AutoSize = true;
			this.rb4Var.Location = new System.Drawing.Point(9, 59);
			this.rb4Var.Name = "rb4Var";
			this.rb4Var.Size = new System.Drawing.Size(291, 17);
			this.rb4Var.TabIndex = 1;
			this.rb4Var.Text = "(4 variations) An Intro, 4 Variation and an Ending buttons";
			this.rb4Var.UseVisualStyleBackColor = true;
			// 
			// rb2Var
			// 
			this.rb2Var.AutoSize = true;
			this.rb2Var.Checked = true;
			this.rb2Var.Location = new System.Drawing.Point(9, 36);
			this.rb2Var.Name = "rb2Var";
			this.rb2Var.Size = new System.Drawing.Size(392, 17);
			this.rb2Var.TabIndex = 0;
			this.rb2Var.TabStop = true;
			this.rb2Var.Text = "(2 variations) An Intro, an Original and a Variation, a Fill and an Ending button" +
    "s";
			this.rb2Var.UseVisualStyleBackColor = true;
			this.rb2Var.CheckedChanged += new System.EventHandler(this.rb2Var_CheckedChanged);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(274, 190);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(355, 190);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// nudTempo
			// 
			this.nudTempo.Location = new System.Drawing.Point(74, 49);
			this.nudTempo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.nudTempo.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.nudTempo.Name = "nudTempo";
			this.nudTempo.Size = new System.Drawing.Size(68, 20);
			this.nudTempo.TabIndex = 6;
			this.nudTempo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// frmNewStyle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 222);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNewStyle";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create a new Roland style";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbMeasure;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rb4Var;
		private System.Windows.Forms.RadioButton rb2Var;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.NumericUpDown nudTempo;
	}
}