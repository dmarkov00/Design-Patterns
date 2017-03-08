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
        IFactory f;
        private void btnBoatRacing_Click(object sender, EventArgs e)
        {
            // Based on the button click the factory becomes a boat factory
            f = new RaceboatFactory();

            // Generating objects from the factory
            IFastVehicle fastBoatVehicle = f.CreateFastRacingVehicle();
            ISlowVehicle slowBoatVehicle = f.CreateSlowRacingVehicle();

            // Updating listbox
            logListBox.Items.Add("-------A very dynamic race with boats started-------");
            logListBox.Items.Add("");

            // Making use of the fast vehicle by calling the methods and directly adding them to
            // the list box
            logListBox.Items.Add(fastBoatVehicle.MoveFast());
            logListBox.Items.Add(fastBoatVehicle.GainSpeed());

            // Making use of the slow vehicle
            logListBox.Items.Add(slowBoatVehicle.DodgeObstacles());
            logListBox.Items.Add(slowBoatVehicle.MoveSlowly());
        }

        private void btnCarRacing_Click(object sender, EventArgs e)
        {
            // Based on the button click the factory becomes a car factory
            f = new RacecarFactory();

            // Generating objects from the factory
            IFastVehicle fastCarVehicle = f.CreateFastRacingVehicle();
            ISlowVehicle slowCarVehicle = f.CreateSlowRacingVehicle();

            // Updating listbox
            logListBox.Items.Add("-------A very dynamic race with cars started-------");
            logListBox.Items.Add("");

            // Making use of the fast vehicle by calling the methods and directly adding them to
            // the list box
            logListBox.Items.Add(fastCarVehicle.MoveFast());
            logListBox.Items.Add(fastCarVehicle.GainSpeed());

            // Making use of the slow vehicle
            logListBox.Items.Add(slowCarVehicle.DodgeObstacles());
            logListBox.Items.Add(slowCarVehicle.MoveSlowly());
        }
    }
}
