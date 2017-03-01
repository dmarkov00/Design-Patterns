using System.Windows.Forms;
using Accessories;
using Cars;
using System.Collections.Generic;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ICar car;

        /// <summary>
        /// Creating different car based on the clicked button
        /// Loops through all the items in the listbox and
        /// decorates the newly created object
        /// </summary>
        private void MercBtn_Click(object sender, System.EventArgs e)
        {
            car = new Mercedes();
            foreach (var item in AccessoriesListBox.SelectedItems)
            {
                switch (item.ToString())
                {
                    case "Bumper - 2500": car = new Bumper(car); break;
                    case "Spoiler - 1000": car = new Spoiler(car); break;
                    case "Sport seats - 1400": car = new SportSeats(car); break;
                }

            }

            costLabel.Text = car.CalculateCost().ToString();
        }

        /// <summary>
        /// Creating different car based on the clicked button
        /// Loops through all the items in the listbox and
        /// decorates the newly created object
        /// </summary>
        private void FerrariBtn_Click(object sender, System.EventArgs e)
        {
            car = new Ferrari();
            foreach (var item in AccessoriesListBox.SelectedItems)
            {
                switch (item.ToString())
                {
                    case "Bumper - 2500": car = new Bumper(car); break;
                    case "Spoiler - 1000": car = new Spoiler(car); break;
                    case "Sport seats - 1400": car = new SportSeats(car); break;
                }

            }

            costLabel.Text = car.CalculateCost().ToString();
        }
    }
}
