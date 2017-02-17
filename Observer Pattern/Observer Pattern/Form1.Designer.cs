namespace Observer_Pattern
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
            this.newestNumbersDrawnLabel = new System.Windows.Forms.Label();
            this.ScheduleTimerBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sheduleTimerLabel = new System.Windows.Forms.Label();
            this.drawNumbersLabel = new System.Windows.Forms.Label();
            this.DrawNumbersBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.topicLabel = new System.Windows.Forms.Label();
            this.StartParticipant1Btn = new System.Windows.Forms.Button();
            this.StartParticipant2Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // newestNumbersDrawnLabel
            // 
            this.newestNumbersDrawnLabel.AutoSize = true;
            this.newestNumbersDrawnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newestNumbersDrawnLabel.Location = new System.Drawing.Point(36, 415);
            this.newestNumbersDrawnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newestNumbersDrawnLabel.Name = "newestNumbersDrawnLabel";
            this.newestNumbersDrawnLabel.Size = new System.Drawing.Size(225, 20);
            this.newestNumbersDrawnLabel.TabIndex = 14;
            this.newestNumbersDrawnLabel.Text = "The newest numbers drawn: ";
            // 
            // ScheduleTimerBtn
            // 
            this.ScheduleTimerBtn.Location = new System.Drawing.Point(39, 287);
            this.ScheduleTimerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ScheduleTimerBtn.Name = "ScheduleTimerBtn";
            this.ScheduleTimerBtn.Size = new System.Drawing.Size(119, 58);
            this.ScheduleTimerBtn.TabIndex = 13;
            this.ScheduleTimerBtn.Text = "Schedule timer";
            this.ScheduleTimerBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(410, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "minutes";
            // 
            // sheduleTimerLabel
            // 
            this.sheduleTimerLabel.AutoSize = true;
            this.sheduleTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sheduleTimerLabel.Location = new System.Drawing.Point(34, 223);
            this.sheduleTimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sheduleTimerLabel.Name = "sheduleTimerLabel";
            this.sheduleTimerLabel.Size = new System.Drawing.Size(310, 20);
            this.sheduleTimerLabel.TabIndex = 11;
            this.sheduleTimerLabel.Text = "Shedule a timer to draw for you on every";
            // 
            // drawNumbersLabel
            // 
            this.drawNumbersLabel.AutoSize = true;
            this.drawNumbersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawNumbersLabel.Location = new System.Drawing.Point(33, 81);
            this.drawNumbersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawNumbersLabel.Name = "drawNumbersLabel";
            this.drawNumbersLabel.Size = new System.Drawing.Size(245, 20);
            this.drawNumbersLabel.TabIndex = 10;
            this.drawNumbersLabel.Text = "Draw numbers for instant game";
            // 
            // DrawNumbersBtn
            // 
            this.DrawNumbersBtn.Location = new System.Drawing.Point(39, 127);
            this.DrawNumbersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DrawNumbersBtn.Name = "DrawNumbersBtn";
            this.DrawNumbersBtn.Size = new System.Drawing.Size(119, 41);
            this.DrawNumbersBtn.TabIndex = 9;
            this.DrawNumbersBtn.Text = "Draw";
            this.DrawNumbersBtn.UseVisualStyleBackColor = true;
            this.DrawNumbersBtn.Click += new System.EventHandler(this.DrawNumbersBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, -42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hello, you are the operator of \"Lotto extreme\"";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(352, 223);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown1.TabIndex = 15;
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topicLabel.Location = new System.Drawing.Point(32, 4);
            this.topicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(491, 29);
            this.topicLabel.TabIndex = 16;
            this.topicLabel.Text = "Hello, you are the operator of \"Lotto extreme\"";
            // 
            // StartParticipant1Btn
            // 
            this.StartParticipant1Btn.Location = new System.Drawing.Point(460, 81);
            this.StartParticipant1Btn.Name = "StartParticipant1Btn";
            this.StartParticipant1Btn.Size = new System.Drawing.Size(142, 37);
            this.StartParticipant1Btn.TabIndex = 17;
            this.StartParticipant1Btn.Text = "Start Participant1";
            this.StartParticipant1Btn.UseVisualStyleBackColor = true;
            this.StartParticipant1Btn.Click += new System.EventHandler(this.StartParticipant1Btn_Click);
            // 
            // StartParticipant2Btn
            // 
            this.StartParticipant2Btn.Location = new System.Drawing.Point(460, 136);
            this.StartParticipant2Btn.Name = "StartParticipant2Btn";
            this.StartParticipant2Btn.Size = new System.Drawing.Size(142, 38);
            this.StartParticipant2Btn.TabIndex = 18;
            this.StartParticipant2Btn.Text = "Start Participant2";
            this.StartParticipant2Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 480);
            this.Controls.Add(this.StartParticipant2Btn);
            this.Controls.Add(this.StartParticipant1Btn);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.newestNumbersDrawnLabel);
            this.Controls.Add(this.ScheduleTimerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sheduleTimerLabel);
            this.Controls.Add(this.drawNumbersLabel);
            this.Controls.Add(this.DrawNumbersBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newestNumbersDrawnLabel;
        private System.Windows.Forms.Button ScheduleTimerBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sheduleTimerLabel;
        private System.Windows.Forms.Label drawNumbersLabel;
        private System.Windows.Forms.Button DrawNumbersBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.Button StartParticipant1Btn;
        private System.Windows.Forms.Button StartParticipant2Btn;
    }
}

