using System;
using System.Windows.Forms;
using DiskScheduling;
using System.Collections.Generic;

namespace Week1_Dimitar_Markov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            currentList = new List<int> { 40, 2, 22, 66, 67, 33, 80, 75, 85, 65, 8 };
            PopulateFormList(currentList, defaultListValue);
            timer1.Tick += Timer1_Tick;
        }

        private List<int> currentList;
        private Head head;
        private IScheduler scheduler;
        private const int defaultListValue = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Point point = new Point(50,0);
            if (radioButtonFCFS.Checked)
            {
                scheduler = new FCFS();
                head = new Head(scheduler);
                currentList = head.ScheduleNextRequstedNumber(currentList);
                PopulateFormList(currentList, head.NumberToBeRemoved);

            }
            else if (radioButtonSSTF.Checked)
            {
                scheduler = new SSTF();
                head = new Head(scheduler);
                // Setting the correct head location, for usage in the scheduling method
                ((SSTF)scheduler).HeadLocation = trackBar1.Value;
                currentList = head.ScheduleNextRequstedNumber(currentList);

                PopulateFormList(currentList, head.NumberToBeRemoved);


            }
            else if (radioButtonSCAN.Checked)
            {
                scheduler = new Elevator();
                head = new Head(scheduler);

                // Setting the correct head location, for usage in the scheduling method
                ((Elevator)scheduler).HeadLocation = trackBar1.Value;
                
                currentList = head.ScheduleNextRequstedNumber(currentList);

                PopulateFormList(currentList, head.NumberToBeRemoved);
            }

        }

        private void PopulateFormList(List<int> numbersToPopulate, int numberToBeRemoved)
        {
            trackBar1.Value = numberToBeRemoved;
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.Items.Add(numberToBeRemoved);
            // List box to to be empty by default
            if (numberToBeRemoved == 0)
            {
                listBox1.Items.Clear();
            }
            foreach (var item in numbersToPopulate)
            {
                listBox2.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
