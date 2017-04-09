namespace Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OnTvRadioButton = new System.Windows.Forms.RadioButton();
            this.OffTvRadioButton = new System.Windows.Forms.RadioButton();
            this.VolumeUpTvRadioButton = new System.Windows.Forms.RadioButton();
            this.VolumeDownTVRadioButton = new System.Windows.Forms.RadioButton();
            this.BtnExecuteTVCommand = new System.Windows.Forms.Button();
            this.VolumeDownSpeakersRadioButton = new System.Windows.Forms.RadioButton();
            this.VolumeUpSpeakersRadioButton = new System.Windows.Forms.RadioButton();
            this.OffSpeakersRadioButton = new System.Windows.Forms.RadioButton();
            this.OnSpeakersRadioButton = new System.Windows.Forms.RadioButton();
            this.BtnExecuteSpeakersCommand = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnExecuteTVCommand);
            this.panel1.Controls.Add(this.VolumeDownTVRadioButton);
            this.panel1.Controls.Add(this.VolumeUpTvRadioButton);
            this.panel1.Controls.Add(this.OffTvRadioButton);
            this.panel1.Controls.Add(this.OnTvRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(65, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 366);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TV remote";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnExecuteSpeakersCommand);
            this.panel2.Controls.Add(this.VolumeDownSpeakersRadioButton);
            this.panel2.Controls.Add(this.VolumeUpSpeakersRadioButton);
            this.panel2.Controls.Add(this.OffSpeakersRadioButton);
            this.panel2.Controls.Add(this.OnSpeakersRadioButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(274, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 366);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speakers remote";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(455, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 356);
            this.listBox1.TabIndex = 2;
            // 
            // OnTvRadioButton
            // 
            this.OnTvRadioButton.AutoSize = true;
            this.OnTvRadioButton.Location = new System.Drawing.Point(10, 82);
            this.OnTvRadioButton.Name = "OnTvRadioButton";
            this.OnTvRadioButton.Size = new System.Drawing.Size(48, 21);
            this.OnTvRadioButton.TabIndex = 6;
            this.OnTvRadioButton.TabStop = true;
            this.OnTvRadioButton.Text = "On";
            this.OnTvRadioButton.UseVisualStyleBackColor = true;
            this.OnTvRadioButton.CheckedChanged += new System.EventHandler(this.OnTvRadioButton_CheckedChanged);
            // 
            // OffTvRadioButton
            // 
            this.OffTvRadioButton.AutoSize = true;
            this.OffTvRadioButton.Location = new System.Drawing.Point(10, 118);
            this.OffTvRadioButton.Name = "OffTvRadioButton";
            this.OffTvRadioButton.Size = new System.Drawing.Size(48, 21);
            this.OffTvRadioButton.TabIndex = 7;
            this.OffTvRadioButton.TabStop = true;
            this.OffTvRadioButton.Text = "Off";
            this.OffTvRadioButton.UseVisualStyleBackColor = true;
            this.OffTvRadioButton.CheckedChanged += new System.EventHandler(this.OffTvRadioButton_CheckedChanged);
            // 
            // VolumeUpTvRadioButton
            // 
            this.VolumeUpTvRadioButton.AutoSize = true;
            this.VolumeUpTvRadioButton.Location = new System.Drawing.Point(10, 158);
            this.VolumeUpTvRadioButton.Name = "VolumeUpTvRadioButton";
            this.VolumeUpTvRadioButton.Size = new System.Drawing.Size(88, 21);
            this.VolumeUpTvRadioButton.TabIndex = 8;
            this.VolumeUpTvRadioButton.TabStop = true;
            this.VolumeUpTvRadioButton.Text = "Volume +";
            this.VolumeUpTvRadioButton.UseVisualStyleBackColor = true;
            this.VolumeUpTvRadioButton.CheckedChanged += new System.EventHandler(this.VolumeUpTvRadioButton_CheckedChanged);
            // 
            // VolumeDownTVRadioButton
            // 
            this.VolumeDownTVRadioButton.AutoSize = true;
            this.VolumeDownTVRadioButton.Location = new System.Drawing.Point(10, 199);
            this.VolumeDownTVRadioButton.Name = "VolumeDownTVRadioButton";
            this.VolumeDownTVRadioButton.Size = new System.Drawing.Size(85, 21);
            this.VolumeDownTVRadioButton.TabIndex = 9;
            this.VolumeDownTVRadioButton.TabStop = true;
            this.VolumeDownTVRadioButton.Text = "Volume -";
            this.VolumeDownTVRadioButton.UseVisualStyleBackColor = true;
            this.VolumeDownTVRadioButton.CheckedChanged += new System.EventHandler(this.VolumeDownTVRadioButton_CheckedChanged);
            // 
            // BtnExecuteTVCommand
            // 
            this.BtnExecuteTVCommand.Location = new System.Drawing.Point(10, 258);
            this.BtnExecuteTVCommand.Name = "BtnExecuteTVCommand";
            this.BtnExecuteTVCommand.Size = new System.Drawing.Size(101, 61);
            this.BtnExecuteTVCommand.TabIndex = 10;
            this.BtnExecuteTVCommand.Text = "Execute TV comand";
            this.BtnExecuteTVCommand.UseVisualStyleBackColor = true;
            this.BtnExecuteTVCommand.Click += new System.EventHandler(this.BtnExecuteTVCommand_Click);
            // 
            // VolumeDownSpeakersRadioButton
            // 
            this.VolumeDownSpeakersRadioButton.AutoSize = true;
            this.VolumeDownSpeakersRadioButton.Location = new System.Drawing.Point(9, 199);
            this.VolumeDownSpeakersRadioButton.Name = "VolumeDownSpeakersRadioButton";
            this.VolumeDownSpeakersRadioButton.Size = new System.Drawing.Size(85, 21);
            this.VolumeDownSpeakersRadioButton.TabIndex = 13;
            this.VolumeDownSpeakersRadioButton.TabStop = true;
            this.VolumeDownSpeakersRadioButton.Text = "Volume -";
            this.VolumeDownSpeakersRadioButton.UseVisualStyleBackColor = true;
            this.VolumeDownSpeakersRadioButton.CheckedChanged += new System.EventHandler(this.VolumeDownSpeakersRadioButton_CheckedChanged);
            // 
            // VolumeUpSpeakersRadioButton
            // 
            this.VolumeUpSpeakersRadioButton.AutoSize = true;
            this.VolumeUpSpeakersRadioButton.Location = new System.Drawing.Point(9, 158);
            this.VolumeUpSpeakersRadioButton.Name = "VolumeUpSpeakersRadioButton";
            this.VolumeUpSpeakersRadioButton.Size = new System.Drawing.Size(88, 21);
            this.VolumeUpSpeakersRadioButton.TabIndex = 12;
            this.VolumeUpSpeakersRadioButton.TabStop = true;
            this.VolumeUpSpeakersRadioButton.Text = "Volume +";
            this.VolumeUpSpeakersRadioButton.UseVisualStyleBackColor = true;
            this.VolumeUpSpeakersRadioButton.CheckedChanged += new System.EventHandler(this.VolumeUpSpeakersRadioButton_CheckedChanged);
            // 
            // OffSpeakersRadioButton
            // 
            this.OffSpeakersRadioButton.AutoSize = true;
            this.OffSpeakersRadioButton.Location = new System.Drawing.Point(9, 118);
            this.OffSpeakersRadioButton.Name = "OffSpeakersRadioButton";
            this.OffSpeakersRadioButton.Size = new System.Drawing.Size(48, 21);
            this.OffSpeakersRadioButton.TabIndex = 11;
            this.OffSpeakersRadioButton.TabStop = true;
            this.OffSpeakersRadioButton.Text = "Off";
            this.OffSpeakersRadioButton.UseVisualStyleBackColor = true;
            this.OffSpeakersRadioButton.CheckedChanged += new System.EventHandler(this.OffSpeakersRadioButton_CheckedChanged);
            // 
            // OnSpeakersRadioButton
            // 
            this.OnSpeakersRadioButton.AutoSize = true;
            this.OnSpeakersRadioButton.Location = new System.Drawing.Point(9, 82);
            this.OnSpeakersRadioButton.Name = "OnSpeakersRadioButton";
            this.OnSpeakersRadioButton.Size = new System.Drawing.Size(48, 21);
            this.OnSpeakersRadioButton.TabIndex = 10;
            this.OnSpeakersRadioButton.TabStop = true;
            this.OnSpeakersRadioButton.Text = "On";
            this.OnSpeakersRadioButton.UseVisualStyleBackColor = true;
            this.OnSpeakersRadioButton.CheckedChanged += new System.EventHandler(this.OnSpeakersRadioButton_CheckedChanged);
            // 
            // BtnExecuteSpeakersCommand
            // 
            this.BtnExecuteSpeakersCommand.Location = new System.Drawing.Point(10, 258);
            this.BtnExecuteSpeakersCommand.Name = "BtnExecuteSpeakersCommand";
            this.BtnExecuteSpeakersCommand.Size = new System.Drawing.Size(101, 61);
            this.BtnExecuteSpeakersCommand.TabIndex = 14;
            this.BtnExecuteSpeakersCommand.Text = "Execute speakers comand";
            this.BtnExecuteSpeakersCommand.UseVisualStyleBackColor = true;
            this.BtnExecuteSpeakersCommand.Click += new System.EventHandler(this.BtnExecuteSpeakersCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 400);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnExecuteTVCommand;
        private System.Windows.Forms.RadioButton VolumeDownTVRadioButton;
        private System.Windows.Forms.RadioButton VolumeUpTvRadioButton;
        private System.Windows.Forms.RadioButton OffTvRadioButton;
        private System.Windows.Forms.RadioButton OnTvRadioButton;
        private System.Windows.Forms.Button BtnExecuteSpeakersCommand;
        private System.Windows.Forms.RadioButton VolumeDownSpeakersRadioButton;
        private System.Windows.Forms.RadioButton VolumeUpSpeakersRadioButton;
        private System.Windows.Forms.RadioButton OffSpeakersRadioButton;
        private System.Windows.Forms.RadioButton OnSpeakersRadioButton;
    }
}

