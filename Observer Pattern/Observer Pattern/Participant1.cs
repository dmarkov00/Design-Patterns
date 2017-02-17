using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class Participant1 : Form, IParticipant
    {
        public Participant1(Lottery lottery)
        {
            InitializeComponent();
            Lottery = lottery;
            Lottery.Register(this);

        }
        public Lottery Lottery { get; set; }
        List<int> selectedNumbers = new List<int>();

        public void Update(List<int> numbers)
        {
            nmbrsCurrentlyDrawnLabel.Text = " ";
            foreach (var item in numbers)
            {
                nmbrsCurrentlyDrawnLabel.Text += item.ToString() + ", ";
            }
        }

        private void chooseNumberBtn_Click(object sender, EventArgs e)
        {
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
