using System;
using System.Windows.Forms;
using LotteryParticipant_Observer_;
using System.Collections.Generic;

namespace Lottery_Object_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lottery = new Lottery();
            
        }
        Lottery lottery;


        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = ""; 
            List<int> numbers = lottery.GenerateRandomNumbers();
            foreach (var item in numbers)
            {
                label6.Text += item + ",";
            }
        }
    }
}
