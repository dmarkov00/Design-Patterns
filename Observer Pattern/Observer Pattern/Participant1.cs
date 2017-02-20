using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Observer_Pattern
{

    /// ///////////////////////////////////////////////////////////////////////

    // The comments in this class are also valid for Participant2

    /// ///////////////////////////////////////////////////////////////////////

    public partial class Participant1 : Form, IParticipant
    {
        public Participant1(Lottery lottery)
        {
            InitializeComponent();
            Lottery = lottery;
            this.Name = "Grandma Milthreat";
            label2.Text = this.Name;

            Lottery.Register(this);

        }
        public Lottery Lottery { get; set; }
        List<int> selectedNumbers = new List<int>();

        /// <summary>
        /// Implenetation of update method from IParticipant.
        /// Receives the newly generated numbers and displays it in the form
        /// </summary>
        /// <param name="numbers"></param>
        public void Update(List<int> numbers)
        {
            nmbrsCurrentlyDrawnLabel.Text = "Numbers currently drawn:  ";
            foreach (var item in numbers)
            {
                nmbrsCurrentlyDrawnLabel.Text += item.ToString() + ", ";
            }
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

        // Passing the current Observer for registering
        private void Participant1SubscribeBtn_Click(object sender, EventArgs e)
        {
            Lottery.Register(this);
        }

        // Passing the current Observer for removing

        private void Participant1UnsubscribeBtn_Click(object sender, EventArgs e)
        {
            Lottery.Unregister(this);
        }

      
    }
}
