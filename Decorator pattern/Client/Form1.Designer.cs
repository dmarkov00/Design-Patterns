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
            this.MercedesBtn = new System.Windows.Forms.Label();
            this.MercBtn = new System.Windows.Forms.Button();
            this.FerrariBtn = new System.Windows.Forms.Button();
            this.AccessoriesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MercedesBtn
            // 
            this.MercedesBtn.AutoSize = true;
            this.MercedesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MercedesBtn.Location = new System.Drawing.Point(158, 21);
            this.MercedesBtn.Name = "MercedesBtn";
            this.MercedesBtn.Size = new System.Drawing.Size(201, 25);
            this.MercedesBtn.TabIndex = 0;
            this.MercedesBtn.Text = "Welcome to car shop ";
            // 
            // MercBtn
            // 
            this.MercBtn.Location = new System.Drawing.Point(49, 90);
            this.MercBtn.Name = "MercBtn";
            this.MercBtn.Size = new System.Drawing.Size(220, 41);
            this.MercBtn.TabIndex = 1;
            this.MercBtn.Text = "Order a Mercedes";
            this.MercBtn.UseVisualStyleBackColor = true;
            this.MercBtn.Click += new System.EventHandler(this.MercBtn_Click);
            // 
            // FerrariBtn
            // 
            this.FerrariBtn.Location = new System.Drawing.Point(49, 189);
            this.FerrariBtn.Name = "FerrariBtn";
            this.FerrariBtn.Size = new System.Drawing.Size(220, 40);
            this.FerrariBtn.TabIndex = 2;
            this.FerrariBtn.Text = "Order a  Ferrari";
            this.FerrariBtn.UseVisualStyleBackColor = true;
            this.FerrariBtn.Click += new System.EventHandler(this.FerrariBtn_Click);
            // 
            // AccessoriesListBox
            // 
            this.AccessoriesListBox.FormattingEnabled = true;
            this.AccessoriesListBox.ItemHeight = 16;
            this.AccessoriesListBox.Items.AddRange(new object[] {
            "Bumper - 2500",
            "Spoiler - 1000",
            "Sport seats - 1400"});
            this.AccessoriesListBox.Location = new System.Drawing.Point(409, 101);
            this.AccessoriesListBox.Name = "AccessoriesListBox";
            this.AccessoriesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.AccessoriesListBox.Size = new System.Drawing.Size(120, 180);
            this.AccessoriesListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "First choose accessories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cost of the last ordered car:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(258, 368);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(12, 17);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price: 100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price: 200000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccessoriesListBox);
            this.Controls.Add(this.FerrariBtn);
            this.Controls.Add(this.MercBtn);
            this.Controls.Add(this.MercedesBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MercedesBtn;
        private System.Windows.Forms.Button MercBtn;
        private System.Windows.Forms.Button FerrariBtn;
        private System.Windows.Forms.ListBox AccessoriesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

