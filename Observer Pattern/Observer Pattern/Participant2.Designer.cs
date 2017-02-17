namespace Observer_Pattern
{
    partial class Participant2
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
            this.Participant2UnsubscribeBtn = new System.Windows.Forms.Button();
            this.Participant2SubscribeBtn = new System.Windows.Forms.Button();
            this.nmbrsCurrentlyDrawnLabel = new System.Windows.Forms.Label();
            this.selectedLuckyNumbersLabel = new System.Windows.Forms.Label();
            this.chooseNumberBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Participant2UnsubscribeBtn
            // 
            this.Participant2UnsubscribeBtn.Location = new System.Drawing.Point(578, 438);
            this.Participant2UnsubscribeBtn.Name = "Participant2UnsubscribeBtn";
            this.Participant2UnsubscribeBtn.Size = new System.Drawing.Size(113, 43);
            this.Participant2UnsubscribeBtn.TabIndex = 19;
            this.Participant2UnsubscribeBtn.Text = "Unregister";
            this.Participant2UnsubscribeBtn.UseVisualStyleBackColor = true;
            this.Participant2UnsubscribeBtn.Click += new System.EventHandler(this.Participant2UnsubscribeBtn_Click);
            // 
            // Participant2SubscribeBtn
            // 
            this.Participant2SubscribeBtn.Location = new System.Drawing.Point(578, 349);
            this.Participant2SubscribeBtn.Name = "Participant2SubscribeBtn";
            this.Participant2SubscribeBtn.Size = new System.Drawing.Size(113, 43);
            this.Participant2SubscribeBtn.TabIndex = 18;
            this.Participant2SubscribeBtn.Text = "Register";
            this.Participant2SubscribeBtn.UseVisualStyleBackColor = true;
            this.Participant2SubscribeBtn.Click += new System.EventHandler(this.Participant2SubscribeBtn_Click);
            // 
            // nmbrsCurrentlyDrawnLabel
            // 
            this.nmbrsCurrentlyDrawnLabel.AutoSize = true;
            this.nmbrsCurrentlyDrawnLabel.Location = new System.Drawing.Point(114, 223);
            this.nmbrsCurrentlyDrawnLabel.Name = "nmbrsCurrentlyDrawnLabel";
            this.nmbrsCurrentlyDrawnLabel.Size = new System.Drawing.Size(0, 17);
            this.nmbrsCurrentlyDrawnLabel.TabIndex = 17;
            // 
            // selectedLuckyNumbersLabel
            // 
            this.selectedLuckyNumbersLabel.AutoSize = true;
            this.selectedLuckyNumbersLabel.Location = new System.Drawing.Point(114, 272);
            this.selectedLuckyNumbersLabel.Name = "selectedLuckyNumbersLabel";
            this.selectedLuckyNumbersLabel.Size = new System.Drawing.Size(0, 17);
            this.selectedLuckyNumbersLabel.TabIndex = 16;
            // 
            // chooseNumberBtn
            // 
            this.chooseNumberBtn.Location = new System.Drawing.Point(361, 170);
            this.chooseNumberBtn.Name = "chooseNumberBtn";
            this.chooseNumberBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseNumberBtn.TabIndex = 15;
            this.chooseNumberBtn.Text = "OK";
            this.chooseNumberBtn.UseVisualStyleBackColor = true;
            this.chooseNumberBtn.Click += new System.EventHandler(this.chooseNumberBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 14;
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
            this.checkedListBox1.Location = new System.Drawing.Point(48, 68);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(79, 344);
            this.checkedListBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // Participant2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Participant2UnsubscribeBtn);
            this.Controls.Add(this.Participant2SubscribeBtn);
            this.Controls.Add(this.nmbrsCurrentlyDrawnLabel);
            this.Controls.Add(this.selectedLuckyNumbersLabel);
            this.Controls.Add(this.chooseNumberBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Participant2";
            this.Text = "Participant2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Participant2UnsubscribeBtn;
        private System.Windows.Forms.Button Participant2SubscribeBtn;
        private System.Windows.Forms.Label nmbrsCurrentlyDrawnLabel;
        private System.Windows.Forms.Label selectedLuckyNumbersLabel;
        private System.Windows.Forms.Button chooseNumberBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
    }
}