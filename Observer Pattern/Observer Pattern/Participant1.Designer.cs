﻿namespace Observer_Pattern
{
    partial class Participant1
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
            this.nmbrsCurrentlyDrawnLabel = new System.Windows.Forms.Label();
            this.selectedLuckyNumbersLabel = new System.Windows.Forms.Label();
            this.chooseNumberBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Participant1SubscribeBtn = new System.Windows.Forms.Button();
            this.Participant1UnsubscribeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nmbrsCurrentlyDrawnLabel
            // 
            this.nmbrsCurrentlyDrawnLabel.AutoSize = true;
            this.nmbrsCurrentlyDrawnLabel.Location = new System.Drawing.Point(124, 191);
            this.nmbrsCurrentlyDrawnLabel.Name = "nmbrsCurrentlyDrawnLabel";
            this.nmbrsCurrentlyDrawnLabel.Size = new System.Drawing.Size(12, 17);
            this.nmbrsCurrentlyDrawnLabel.TabIndex = 10;
            this.nmbrsCurrentlyDrawnLabel.Text = " ";
            // 
            // selectedLuckyNumbersLabel
            // 
            this.selectedLuckyNumbersLabel.AutoSize = true;
            this.selectedLuckyNumbersLabel.Location = new System.Drawing.Point(124, 240);
            this.selectedLuckyNumbersLabel.Name = "selectedLuckyNumbersLabel";
            this.selectedLuckyNumbersLabel.Size = new System.Drawing.Size(12, 17);
            this.selectedLuckyNumbersLabel.TabIndex = 9;
            this.selectedLuckyNumbersLabel.Text = " ";
            // 
            // chooseNumberBtn
            // 
            this.chooseNumberBtn.Location = new System.Drawing.Point(371, 138);
            this.chooseNumberBtn.Name = "chooseNumberBtn";
            this.chooseNumberBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseNumberBtn.TabIndex = 8;
            this.chooseNumberBtn.Text = "OK";
            this.chooseNumberBtn.UseVisualStyleBackColor = true;
            this.chooseNumberBtn.Click += new System.EventHandler(this.chooseNumberBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose 5 lucky numbers and click \"OK\"";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.checkedListBox1.Location = new System.Drawing.Point(58, 36);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(79, 344);
            this.checkedListBox1.TabIndex = 6;
            // 
            // Participant1SubscribeBtn
            // 
            this.Participant1SubscribeBtn.Location = new System.Drawing.Point(588, 317);
            this.Participant1SubscribeBtn.Name = "Participant1SubscribeBtn";
            this.Participant1SubscribeBtn.Size = new System.Drawing.Size(113, 43);
            this.Participant1SubscribeBtn.TabIndex = 11;
            this.Participant1SubscribeBtn.Text = "Register";
            this.Participant1SubscribeBtn.UseVisualStyleBackColor = true;
            this.Participant1SubscribeBtn.Click += new System.EventHandler(this.Participant1SubscribeBtn_Click);
            // 
            // Participant1UnsubscribeBtn
            // 
            this.Participant1UnsubscribeBtn.Location = new System.Drawing.Point(588, 406);
            this.Participant1UnsubscribeBtn.Name = "Participant1UnsubscribeBtn";
            this.Participant1UnsubscribeBtn.Size = new System.Drawing.Size(113, 43);
            this.Participant1UnsubscribeBtn.TabIndex = 12;
            this.Participant1UnsubscribeBtn.Text = "Unregister";
            this.Participant1UnsubscribeBtn.UseVisualStyleBackColor = true;
            this.Participant1UnsubscribeBtn.Click += new System.EventHandler(this.Participant1UnsubscribeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // Participant1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Participant1UnsubscribeBtn);
            this.Controls.Add(this.Participant1SubscribeBtn);
            this.Controls.Add(this.nmbrsCurrentlyDrawnLabel);
            this.Controls.Add(this.selectedLuckyNumbersLabel);
            this.Controls.Add(this.chooseNumberBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Participant1";
            this.Text = "Participant1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nmbrsCurrentlyDrawnLabel;
        private System.Windows.Forms.Label selectedLuckyNumbersLabel;
        private System.Windows.Forms.Button chooseNumberBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Participant1SubscribeBtn;
        private System.Windows.Forms.Button Participant1UnsubscribeBtn;
        private System.Windows.Forms.Label label2;
    }
}