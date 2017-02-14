using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LotteryParticipant_Observer_;
using Lottery_Object_;
namespace LotteryParticipantForm_ConcreteObserver_
{
    public partial class Form1 : Form, IParticipant
    {
        public Form1()
        {
            InitializeComponent();
            this.Name = "Grandma Wilmtred";
            lottery.Register(this);
        }
        Lottery lottery = new Lottery();
        public void Update(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                label2.Text += item.ToString() + ", ";
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            lottery.Unregister(this);
        }
        List<int> selectedNumbers = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                selectedNumbers.Add(Convert.ToInt32(itemChecked));
                label2.Text += (string)itemChecked + ", ";
            }

            checkedListBox1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
        }
    }
}
