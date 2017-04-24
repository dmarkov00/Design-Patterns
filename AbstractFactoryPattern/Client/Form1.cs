using RacingGame;
using System;
using System.Windows.Forms;
using FastVehicles;
using SlowVehicles;
namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFactory factory;
        IFastVehicle fastVehicle;
        ISlowVehicle slowVehicle;
            
        private void BoatRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            factory = new RaceboatFactory();          
        }
        private void CarRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            factory = new RacecarFactory();
        }

        private void BtnStartRace_Click(object sender, EventArgs e)
        {
            fastVehicle = factory.CreateFastRacingVehicle();
            slowVehicle = factory.CreateSlowRacingVehicle();

            logListBox.Items.Add("-------A very dynamic race just started-------");
            logListBox.Items.Add("");
            // Making use of the fast vehicle by calling the methods and directly adding them to
            // the list box
            logListBox.Items.Add(fastVehicle.MoveFast());
            logListBox.Items.Add(fastVehicle.GainSpeed());

            // Making use of the slow vehicle
            logListBox.Items.Add(slowVehicle.DodgeObstacles());
            logListBox.Items.Add(slowVehicle.MoveSlowly());
        }
    }
}
