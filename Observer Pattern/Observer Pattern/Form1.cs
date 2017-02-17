using System.Collections.Generic;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lottery = new Lottery();

        }
        private Lottery lottery;
        private void DrawNumbersBtn_Click(object sender, System.EventArgs e)
        {
            newestNumbersDrawnLabel.Text = "";
            List<int> numbers = lottery.GenerateRandomNumbers();
            foreach (int num in numbers)
            {
                newestNumbersDrawnLabel.Text += num + ",";
            }
        }

        private void StartParticipant1Btn_Click(object sender, System.EventArgs e)
        {
            Form participant1 = new Participant1(lottery);
            participant1.Show();
        }
    }
}
