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
            this.lblSpeechOptions = new System.Windows.Forms.Label();
            this.lblDelayMultiplier = new System.Windows.Forms.Label();
            this.lblDelayAdder = new System.Windows.Forms.Label();
            this.nudDelayAdder = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayAdder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.Location = new System.Drawing.Point(12, 179);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(517, 23);
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
            this.txtTextToSpeech.Location = new System.Drawing.Point(12, 25);
            this.txtTextToSpeech.Multiline = true;
            this.txtTextToSpeech.Name = "txtTextToSpeech";
            this.txtTextToSpeech.Size = new System.Drawing.Size(517, 97);
            this.txtTextToSpeech.TabIndex = 1;
            // 
            // nudDelayMultiplier
            // 
            this.nudDelayMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudDelayMultiplier.Location = new System.Drawing.Point(117, 142);
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
            this.lblTextToSpeech.Location = new System.Drawing.Point(12, 9);
            this.lblTextToSpeech.Name = "lblTextToSpeech";
            this.lblTextToSpeech.Size = new System.Drawing.Size(81, 13);
            this.lblTextToSpeech.TabIndex = 3;
            this.lblTextToSpeech.Text = "Text to speech:";
            // 
            // lblSpeechOptions
            // 
            this.lblSpeechOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSpeechOptions.AutoSize = true;
            this.lblSpeechOptions.Location = new System.Drawing.Point(12, 125);
            this.lblSpeechOptions.Name = "lblSpeechOptions";
            this.lblSpeechOptions.Size = new System.Drawing.Size(86, 13);
            this.lblSpeechOptions.TabIndex = 4;
            this.lblSpeechOptions.Text = "Speech Options:";
            // 
            // lblDelayMultiplier
            // 
            this.lblDelayMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDelayMultiplier.AutoSize = true;
            this.lblDelayMultiplier.Location = new System.Drawing.Point(33, 144);
            this.lblDelayMultiplier.Name = "lblDelayMultiplier";
            this.lblDelayMultiplier.Size = new System.Drawing.Size(78, 13);
            this.lblDelayMultiplier.TabIndex = 5;
            this.lblDelayMultiplier.Text = "Delay Multiplier";
            // 
            // lblDelayAdder
            // 
            this.lblDelayAdder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDelayAdder.AutoSize = true;
            this.lblDelayAdder.Location = new System.Drawing.Point(188, 144);
            this.lblDelayAdder.Name = "lblDelayAdder";
            this.lblDelayAdder.Size = new System.Drawing.Size(65, 13);
            this.lblDelayAdder.TabIndex = 6;
            this.lblDelayAdder.Text = "Delay Adder";
            // 
            // nudDelayAdder
            // 
            this.nudDelayAdder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudDelayAdder.Location = new System.Drawing.Point(259, 142);
            this.nudDelayAdder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDelayAdder.Name = "nudDelayAdder";
            this.nudDelayAdder.Size = new System.Drawing.Size(40, 20);
            this.nudDelayAdder.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Note: the delay multiplier / adder \r\nwill take place after a semi-colon.";
            // 
            // btnSetPath
            // 
            this.btnSetPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetPath.Location = new System.Drawing.Point(12, 208);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(99, 23);
            this.btnSetPath.TabIndex = 9;
            this.btnSetPath.Text = "Set Path";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveFile.Location = new System.Drawing.Point(430, 208);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(99, 23);
            this.btnSaveFile.TabIndex = 10;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSavePath.Location = new System.Drawing.Point(117, 208);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(307, 20);
            this.txtSavePath.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 245);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnSetPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDelayAdder);
            this.Controls.Add(this.lblDelayAdder);
            this.Controls.Add(this.lblDelayMultiplier);
            this.Controls.Add(this.lblSpeechOptions);
            this.Controls.Add(this.lblTextToSpeech);
            this.Controls.Add(this.nudDelayMultiplier);
            this.Controls.Add(this.txtTextToSpeech);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(557, 207);
            this.Name = "Form1";
            this.Text = "Study Sound";
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayAdder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtTextToSpeech;
        private System.Windows.Forms.NumericUpDown nudDelayMultiplier;
        private System.Windows.Forms.Label lblTextToSpeech;
        private System.Windows.Forms.Label lblSpeechOptions;
        private System.Windows.Forms.Label lblDelayMultiplier;
        private System.Windows.Forms.Label lblDelayAdder;
        private System.Windows.Forms.NumericUpDown nudDelayAdder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

