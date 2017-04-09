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
            this.label1 = new System.Windows.Forms.Label();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoatRadioBtn = new System.Windows.Forms.RadioButton();
            this.CarRadioBtn = new System.Windows.Forms.RadioButton();
            this.BtnStartRace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the greatest game with boats and cars";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 16;
            this.logListBox.Location = new System.Drawing.Point(82, 226);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(651, 292);
            this.logListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(78, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log: ";
            // 
            // BoatRadioBtn
            // 
            this.BoatRadioBtn.AutoSize = true;
            this.BoatRadioBtn.Location = new System.Drawing.Point(82, 104);
            this.BoatRadioBtn.Name = "BoatRadioBtn";
            this.BoatRadioBtn.Size = new System.Drawing.Size(140, 21);
            this.BoatRadioBtn.TabIndex = 5;
            this.BoatRadioBtn.TabStop = true;
            this.BoatRadioBtn.Text = "Boat racing game";
            this.BoatRadioBtn.UseVisualStyleBackColor = true;
            this.BoatRadioBtn.CheckedChanged += new System.EventHandler(this.BoatRadioBtn_CheckedChanged);
            // 
            // CarRadioBtn
            // 
            this.CarRadioBtn.AutoSize = true;
            this.CarRadioBtn.Location = new System.Drawing.Point(249, 104);
            this.CarRadioBtn.Name = "CarRadioBtn";
            this.CarRadioBtn.Size = new System.Drawing.Size(133, 21);
            this.CarRadioBtn.TabIndex = 6;
            this.CarRadioBtn.TabStop = true;
            this.CarRadioBtn.Text = "Car racing game";
            this.CarRadioBtn.UseVisualStyleBackColor = true;
            this.CarRadioBtn.CheckedChanged += new System.EventHandler(this.CarRadioBtn_CheckedChanged);
            // 
            // BtnStartRace
            // 
            this.BtnStartRace.Location = new System.Drawing.Point(608, 158);
            this.BtnStartRace.Name = "BtnStartRace";
            this.BtnStartRace.Size = new System.Drawing.Size(125, 43);
            this.BtnStartRace.TabIndex = 7;
            this.BtnStartRace.Text = "Start Race";
            this.BtnStartRace.UseVisualStyleBackColor = true;
            this.BtnStartRace.Click += new System.EventHandler(this.BtnStartRace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 545);
            this.Controls.Add(this.BtnStartRace);
            this.Controls.Add(this.CarRadioBtn);
            this.Controls.Add(this.BoatRadioBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton BoatRadioBtn;
        private System.Windows.Forms.RadioButton CarRadioBtn;
        private System.Windows.Forms.Button BtnStartRace;
    }
}

