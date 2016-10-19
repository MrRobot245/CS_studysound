namespace StudySound
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtTextToSpeech = new System.Windows.Forms.TextBox();
            this.nudDelayMultiplier = new System.Windows.Forms.NumericUpDown();
            this.lblTextToSpeech = new System.Windows.Forms.Label();
            this.lblDelayMultiplier = new System.Windows.Forms.Label();
            this.lblDelayAdder = new System.Windows.Forms.Label();
            this.nudDelayAdder = new System.Windows.Forms.NumericUpDown();
            this.lblSectionNote = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
            this.lblSpeechOptions = new System.Windows.Forms.Label();
            this.btnAddTextFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayAdder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(325, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(99, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtTextToSpeech
            // 
            this.txtTextToSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToSpeech.Location = new System.Drawing.Point(12, 41);
            this.txtTextToSpeech.Multiline = true;
            this.txtTextToSpeech.Name = "txtTextToSpeech";
            this.txtTextToSpeech.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextToSpeech.Size = new System.Drawing.Size(517, 95);
            this.txtTextToSpeech.TabIndex = 1;
            // 
            // nudDelayMultiplier
            // 
            this.nudDelayMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudDelayMultiplier.Location = new System.Drawing.Point(130, 166);
            this.nudDelayMultiplier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDelayMultiplier.Name = "nudDelayMultiplier";
            this.nudDelayMultiplier.Size = new System.Drawing.Size(40, 20);
            this.nudDelayMultiplier.TabIndex = 2;
            this.nudDelayMultiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTextToSpeech
            // 
            this.lblTextToSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextToSpeech.AutoSize = true;
            this.lblTextToSpeech.Location = new System.Drawing.Point(12, 25);
            this.lblTextToSpeech.Name = "lblTextToSpeech";
            this.lblTextToSpeech.Size = new System.Drawing.Size(81, 13);
            this.lblTextToSpeech.TabIndex = 3;
            this.lblTextToSpeech.Text = "Text to speech:";
            // 
            // lblDelayMultiplier
            // 
            this.lblDelayMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDelayMultiplier.AutoSize = true;
            this.lblDelayMultiplier.Location = new System.Drawing.Point(46, 168);
            this.lblDelayMultiplier.Name = "lblDelayMultiplier";
            this.lblDelayMultiplier.Size = new System.Drawing.Size(78, 13);
            this.lblDelayMultiplier.TabIndex = 5;
            this.lblDelayMultiplier.Text = "Delay Multiplier";
            // 
            // lblDelayAdder
            // 
            this.lblDelayAdder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDelayAdder.AutoSize = true;
            this.lblDelayAdder.Location = new System.Drawing.Point(188, 168);
            this.lblDelayAdder.Name = "lblDelayAdder";
            this.lblDelayAdder.Size = new System.Drawing.Size(65, 13);
            this.lblDelayAdder.TabIndex = 6;
            this.lblDelayAdder.Text = "Delay Adder";
            // 
            // nudDelayAdder
            // 
            this.nudDelayAdder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudDelayAdder.Location = new System.Drawing.Point(259, 166);
            this.nudDelayAdder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDelayAdder.Name = "nudDelayAdder";
            this.nudDelayAdder.Size = new System.Drawing.Size(40, 20);
            this.nudDelayAdder.TabIndex = 7;
            // 
            // lblSectionNote
            // 
            this.lblSectionNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSectionNote.AutoSize = true;
            this.lblSectionNote.Location = new System.Drawing.Point(416, 160);
            this.lblSectionNote.Name = "lblSectionNote";
            this.lblSectionNote.Size = new System.Drawing.Size(113, 26);
            this.lblSectionNote.TabIndex = 8;
            this.lblSectionNote.Text = "Note: a section is split \r\nby a semi-colon.";
            // 
            // lblRepeat
            // 
            this.lblRepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(316, 168);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(42, 13);
            this.lblRepeat.TabIndex = 12;
            this.lblRepeat.Text = "Repeat";
            // 
            // nudRepeat
            // 
            this.nudRepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudRepeat.Location = new System.Drawing.Point(364, 166);
            this.nudRepeat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(40, 20);
            this.nudRepeat.TabIndex = 13;
            this.nudRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSpeechOptions
            // 
            this.lblSpeechOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSpeechOptions.AutoSize = true;
            this.lblSpeechOptions.Location = new System.Drawing.Point(12, 151);
            this.lblSpeechOptions.Name = "lblSpeechOptions";
            this.lblSpeechOptions.Size = new System.Drawing.Size(83, 13);
            this.lblSpeechOptions.TabIndex = 14;
            this.lblSpeechOptions.Text = "Speech Options";
            // 
            // btnAddTextFile
            // 
            this.btnAddTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTextFile.Location = new System.Drawing.Point(430, 12);
            this.btnAddTextFile.Name = "btnAddTextFile";
            this.btnAddTextFile.Size = new System.Drawing.Size(99, 23);
            this.btnAddTextFile.TabIndex = 17;
            this.btnAddTextFile.Text = "Add Text File(s)";
            this.btnAddTextFile.UseVisualStyleBackColor = true;
            this.btnAddTextFile.Click += new System.EventHandler(this.btnAddTextFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(220, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "wav";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 201);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddTextFile);
            this.Controls.Add(this.lblSpeechOptions);
            this.Controls.Add(this.nudRepeat);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.lblSectionNote);
            this.Controls.Add(this.nudDelayAdder);
            this.Controls.Add(this.lblDelayAdder);
            this.Controls.Add(this.lblDelayMultiplier);
            this.Controls.Add(this.lblTextToSpeech);
            this.Controls.Add(this.nudDelayMultiplier);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtTextToSpeech);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(557, 240);
            this.Name = "Form1";
            this.Text = "Study Sound";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayAdder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtTextToSpeech;
        private System.Windows.Forms.NumericUpDown nudDelayMultiplier;
        private System.Windows.Forms.Label lblTextToSpeech;
        private System.Windows.Forms.Label lblDelayMultiplier;
        private System.Windows.Forms.Label lblDelayAdder;
        private System.Windows.Forms.NumericUpDown nudDelayAdder;
        private System.Windows.Forms.Label lblSectionNote;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.Label lblSpeechOptions;
        private System.Windows.Forms.Button btnAddTextFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

