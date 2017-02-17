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
            newestNumbersDrawnLabel.Text = "The newest numbers drawn: ";
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

        private void StartParticipant2Btn_Click(object sender, System.EventArgs e)
        {
            Form participant2 = new Participant2(lottery);
            participant2.Show();
        }

        private void ScheduleTimerBtn_Click(object sender, System.EventArgs e)
        {
            
            timer1.Interval = (int)numericUpDown1.Value * 60000;
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            newestNumbersDrawnLabel.Text = "The newest numbers drawn: ";
            List<int> numbers = lottery.GenerateRandomNumbers();
            foreach (int num in numbers)
            {
                newestNumbersDrawnLabel.Text += num + ",";
            }
        }

        private void stopTimerBtn_Click(object sender, System.EventArgs e)
        {
            timer1.Stop();
        }
    }
}
