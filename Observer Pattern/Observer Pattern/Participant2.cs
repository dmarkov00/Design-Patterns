using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class Participant2 : Form, IParticipant
    {
        public Participant2(Lottery lottery)
        {
            InitializeComponent();
            Lottery = lottery;
            this.Name = "Grandpa Vlada";
            label2.Text = this.Name;
            Lottery.Register(this);
        }
        public Lottery Lottery { get; set; }
        List<int> selectedNumbers = new List<int>();

        public void Update(List<int> numbers)
        {
            nmbrsCurrentlyDrawnLabel.Text = "Numbers currently drawn:  ";
            foreach (var item in numbers)
            {
                nmbrsCurrentlyDrawnLabel.Text += item.ToString() + ", ";
            }
        }

        private void Participant2SubscribeBtn_Click(object sender, EventArgs e)
        {
            Lottery.Register(this);
        }

        private void Participant2UnsubscribeBtn_Click(object sender, EventArgs e)
        {
            Lottery.Unregister(this);
        }

        private void chooseNumberBtn_Click(object sender, EventArgs e)
        {
            selectedLuckyNumbersLabel.Text = "Your selected lucky numbers are: ";
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                selectedNumbers.Add(Convert.ToInt32(itemChecked));
                selectedLuckyNumbersLabel.Text += (string)itemChecked + ", ";
            }

            checkedListBox1.Visible = false;
            chooseNumberBtn.Visible = false;
            label1.Visible = false;
        }
    }
}
