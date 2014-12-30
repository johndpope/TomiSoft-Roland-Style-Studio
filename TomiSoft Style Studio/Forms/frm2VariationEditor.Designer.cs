namespace TomiSoft_Style_Studio {
	partial class frm2VariationEditor {
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miSave = new System.Windows.Forms.ToolStripMenuItem();
			this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cfsChord = new TomiSoft_Style_Studio.ChordFamilySelector();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.isInstrument = new TomiSoft_Style_Studio.InstrumentSelector();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.rbPartEnding = new System.Windows.Forms.RadioButton();
			this.rbPartFillToOriginal = new System.Windows.Forms.RadioButton();
			this.rbPartFillToVariation = new System.Windows.Forms.RadioButton();
			this.rbPartVariation = new System.Windows.Forms.RadioButton();
			this.rbPartOriginal = new System.Windows.Forms.RadioButton();
			this.rbPartIntro = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.rbArrangementAdvanced = new System.Windows.Forms.RadioButton();
			this.rbArrangementBasic = new System.Windows.Forms.RadioButton();
			this.btnPlayPart = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.btnApplyMessageEdition = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDeleteSelectedMessage = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.lwMessages = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnPlayInstrument = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(827, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miSaveAs});
			this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// miSave
			// 
			this.miSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.miSave.MergeIndex = 2;
			this.miSave.Name = "miSave";
			this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.miSave.Size = new System.Drawing.Size(193, 22);
			this.miSave.Text = "Save";
			// 
			// miSaveAs
			// 
			this.miSaveAs.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.miSaveAs.MergeIndex = 3;
			this.miSaveAs.Name = "miSaveAs";
			this.miSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.miSaveAs.Size = new System.Drawing.Size(193, 22);
			this.miSaveAs.Text = "Save as...";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 581);
			this.panel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.groupBox7);
			this.groupBox1.Controls.Add(this.groupBox6);
			this.groupBox1.Controls.Add(this.btnPlayPart);
			this.groupBox1.Location = new System.Drawing.Point(12, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(175, 502);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Style parts";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cfsChord);
			this.groupBox5.Location = new System.Drawing.Point(84, 258);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(86, 93);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Chord family";
			// 
			// cfsChord
			// 
			this.cfsChord.Location = new System.Drawing.Point(6, 19);
			this.cfsChord.Name = "cfsChord";
			this.cfsChord.Size = new System.Drawing.Size(48, 64);
			this.cfsChord.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.isInstrument);
			this.groupBox2.Location = new System.Drawing.Point(7, 258);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(71, 208);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Instruments";
			// 
			// isInstrument
			// 
			this.isInstrument.Location = new System.Drawing.Point(3, 16);
			this.isInstrument.Name = "isInstrument";
			this.isInstrument.Size = new System.Drawing.Size(62, 186);
			this.isInstrument.TabIndex = 0;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.rbPartEnding);
			this.groupBox7.Controls.Add(this.rbPartFillToOriginal);
			this.groupBox7.Controls.Add(this.rbPartFillToVariation);
			this.groupBox7.Controls.Add(this.rbPartVariation);
			this.groupBox7.Controls.Add(this.rbPartOriginal);
			this.groupBox7.Controls.Add(this.rbPartIntro);
			this.groupBox7.Location = new System.Drawing.Point(6, 91);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(164, 161);
			this.groupBox7.TabIndex = 4;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Part";
			// 
			// rbPartEnding
			// 
			this.rbPartEnding.AutoSize = true;
			this.rbPartEnding.Location = new System.Drawing.Point(6, 134);
			this.rbPartEnding.Name = "rbPartEnding";
			this.rbPartEnding.Size = new System.Drawing.Size(58, 17);
			this.rbPartEnding.TabIndex = 5;
			this.rbPartEnding.Text = "Ending";
			this.rbPartEnding.UseVisualStyleBackColor = true;
			// 
			// rbPartFillToOriginal
			// 
			this.rbPartFillToOriginal.AutoSize = true;
			this.rbPartFillToOriginal.Location = new System.Drawing.Point(6, 111);
			this.rbPartFillToOriginal.Name = "rbPartFillToOriginal";
			this.rbPartFillToOriginal.Size = new System.Drawing.Size(154, 17);
			this.rbPartFillToOriginal.TabIndex = 4;
			this.rbPartFillToOriginal.Text = "Fill from Variation to Original";
			this.rbPartFillToOriginal.UseVisualStyleBackColor = true;
			// 
			// rbPartFillToVariation
			// 
			this.rbPartFillToVariation.AutoSize = true;
			this.rbPartFillToVariation.Location = new System.Drawing.Point(6, 88);
			this.rbPartFillToVariation.Name = "rbPartFillToVariation";
			this.rbPartFillToVariation.Size = new System.Drawing.Size(154, 17);
			this.rbPartFillToVariation.TabIndex = 3;
			this.rbPartFillToVariation.Text = "Fill from Original to Variation";
			this.rbPartFillToVariation.UseVisualStyleBackColor = true;
			// 
			// rbPartVariation
			// 
			this.rbPartVariation.AutoSize = true;
			this.rbPartVariation.Location = new System.Drawing.Point(6, 65);
			this.rbPartVariation.Name = "rbPartVariation";
			this.rbPartVariation.Size = new System.Drawing.Size(66, 17);
			this.rbPartVariation.TabIndex = 2;
			this.rbPartVariation.Text = "Variation";
			this.rbPartVariation.UseVisualStyleBackColor = true;
			// 
			// rbPartOriginal
			// 
			this.rbPartOriginal.AutoSize = true;
			this.rbPartOriginal.Location = new System.Drawing.Point(6, 42);
			this.rbPartOriginal.Name = "rbPartOriginal";
			this.rbPartOriginal.Size = new System.Drawing.Size(60, 17);
			this.rbPartOriginal.TabIndex = 1;
			this.rbPartOriginal.Text = "Original";
			this.rbPartOriginal.UseVisualStyleBackColor = true;
			// 
			// rbPartIntro
			// 
			this.rbPartIntro.AutoSize = true;
			this.rbPartIntro.Checked = true;
			this.rbPartIntro.Location = new System.Drawing.Point(6, 19);
			this.rbPartIntro.Name = "rbPartIntro";
			this.rbPartIntro.Size = new System.Drawing.Size(46, 17);
			this.rbPartIntro.TabIndex = 0;
			this.rbPartIntro.TabStop = true;
			this.rbPartIntro.Text = "Intro";
			this.rbPartIntro.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.rbArrangementAdvanced);
			this.groupBox6.Controls.Add(this.rbArrangementBasic);
			this.groupBox6.Location = new System.Drawing.Point(6, 19);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(164, 66);
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Arrangement (Orchestration)";
			// 
			// rbArrangementAdvanced
			// 
			this.rbArrangementAdvanced.AutoSize = true;
			this.rbArrangementAdvanced.Location = new System.Drawing.Point(6, 42);
			this.rbArrangementAdvanced.Name = "rbArrangementAdvanced";
			this.rbArrangementAdvanced.Size = new System.Drawing.Size(127, 17);
			this.rbArrangementAdvanced.TabIndex = 1;
			this.rbArrangementAdvanced.Text = "Advanced (Full Band)";
			this.rbArrangementAdvanced.UseVisualStyleBackColor = true;
			// 
			// rbArrangementBasic
			// 
			this.rbArrangementBasic.AutoSize = true;
			this.rbArrangementBasic.Checked = true;
			this.rbArrangementBasic.Location = new System.Drawing.Point(6, 19);
			this.rbArrangementBasic.Name = "rbArrangementBasic";
			this.rbArrangementBasic.Size = new System.Drawing.Size(93, 17);
			this.rbArrangementBasic.TabIndex = 0;
			this.rbArrangementBasic.TabStop = true;
			this.rbArrangementBasic.Text = "Basic (Combo)";
			this.rbArrangementBasic.UseVisualStyleBackColor = true;
			// 
			// btnPlayPart
			// 
			this.btnPlayPart.Location = new System.Drawing.Point(6, 472);
			this.btnPlayPart.Name = "btnPlayPart";
			this.btnPlayPart.Size = new System.Drawing.Size(164, 23);
			this.btnPlayPart.TabIndex = 1;
			this.btnPlayPart.Text = "Play selected part";
			this.btnPlayPart.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox4);
			this.panel2.Controls.Add(this.groupBox3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(200, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(627, 581);
			this.panel2.TabIndex = 2;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.listBox3);
			this.groupBox4.Controls.Add(this.btnApplyMessageEdition);
			this.groupBox4.Controls.Add(this.textBox3);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.textBox2);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(6, 4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(609, 149);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Event editor";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Message type:";
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Items.AddRange(new object[] {
            "Control",
            "Program",
            "Pitch bend",
            "Note"});
			this.listBox3.Location = new System.Drawing.Point(9, 34);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(120, 82);
			this.listBox3.TabIndex = 8;
			// 
			// btnApplyMessageEdition
			// 
			this.btnApplyMessageEdition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApplyMessageEdition.Location = new System.Drawing.Point(511, 117);
			this.btnApplyMessageEdition.Name = "btnApplyMessageEdition";
			this.btnApplyMessageEdition.Size = new System.Drawing.Size(92, 23);
			this.btnApplyMessageEdition.TabIndex = 7;
			this.btnApplyMessageEdition.Text = "Add";
			this.btnApplyMessageEdition.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(204, 119);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(41, 20);
			this.textBox3.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(167, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "CPT:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(120, 119);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(41, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(82, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Beat:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(35, 119);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(41, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bar:";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnDeleteSelectedMessage);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.lwMessages);
			this.groupBox3.Controls.Add(this.btnPlayInstrument);
			this.groupBox3.Location = new System.Drawing.Point(6, 159);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(609, 410);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "MIDI Messages";
			// 
			// btnDeleteSelectedMessage
			// 
			this.btnDeleteSelectedMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDeleteSelectedMessage.Enabled = false;
			this.btnDeleteSelectedMessage.Location = new System.Drawing.Point(6, 381);
			this.btnDeleteSelectedMessage.Name = "btnDeleteSelectedMessage";
			this.btnDeleteSelectedMessage.Size = new System.Drawing.Size(108, 23);
			this.btnDeleteSelectedMessage.TabIndex = 10;
			this.btnDeleteSelectedMessage.Text = "Delete selected";
			this.btnDeleteSelectedMessage.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(126, 18);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(141, 23);
			this.button4.TabIndex = 9;
			this.button4.Text = "Record from MIDI device";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(7, 18);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Import from MIDI file";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// lwMessages
			// 
			this.lwMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lwMessages.FullRowSelect = true;
			this.lwMessages.Location = new System.Drawing.Point(6, 47);
			this.lwMessages.Name = "lwMessages";
			this.lwMessages.Size = new System.Drawing.Size(597, 328);
			this.lwMessages.TabIndex = 7;
			this.lwMessages.UseCompatibleStateImageBehavior = false;
			this.lwMessages.View = System.Windows.Forms.View.Details;
			this.lwMessages.DoubleClick += new System.EventHandler(this.lwMessages_DoubleClick);
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Time";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Message";
			this.columnHeader1.Width = 88;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Channel";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Data1";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Data2";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Data3";
			// 
			// btnPlayInstrument
			// 
			this.btnPlayInstrument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlayInstrument.Location = new System.Drawing.Point(529, 18);
			this.btnPlayInstrument.Name = "btnPlayInstrument";
			this.btnPlayInstrument.Size = new System.Drawing.Size(75, 23);
			this.btnPlayInstrument.TabIndex = 1;
			this.btnPlayInstrument.Text = "Play";
			this.btnPlayInstrument.UseVisualStyleBackColor = true;
			this.btnPlayInstrument.Click += new System.EventHandler(this.btnPlayInstrument_Click);
			// 
			// frm2VariationEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(827, 581);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frm2VariationEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "2 Variation Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miSave;
		private System.Windows.Forms.ToolStripMenuItem miSaveAs;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnPlayPart;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Button btnApplyMessageEdition;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView lwMessages;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button btnPlayInstrument;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox5;
		private ChordFamilySelector cfsChord;
		private System.Windows.Forms.GroupBox groupBox2;
		private InstrumentSelector isInstrument;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton rbPartEnding;
		private System.Windows.Forms.RadioButton rbPartFillToOriginal;
		private System.Windows.Forms.RadioButton rbPartFillToVariation;
		private System.Windows.Forms.RadioButton rbPartVariation;
		private System.Windows.Forms.RadioButton rbPartOriginal;
		private System.Windows.Forms.RadioButton rbPartIntro;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.RadioButton rbArrangementAdvanced;
		private System.Windows.Forms.RadioButton rbArrangementBasic;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnDeleteSelectedMessage;
	}
}