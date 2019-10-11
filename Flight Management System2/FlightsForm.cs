using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Management_System
{
    public partial class FlightsForm : Form
    {
        Dictionary<String, List<Flight>> FlightsList = new Dictionary<String, List<Flight>>();
        Dictionary<String, Passenger> PassengersList = new Dictionary<String, Passenger>();
        void fillCombox()
        {
            for (int i = 0; i < FlightsList.Count; ++i)
            {
                cbxDestination.Items.Add(FlightsList.ElementAt(i).Key);
            }
        }

        public FlightsForm(Dictionary<String, List<Flight>> FlightsList, Dictionary<String, Passenger> PassengersList)
        {
            InitializeComponent();
            this.FlightsList = FlightsList;
            this.PassengersList = PassengersList;
            if (cbxDestination.Items.Count == 0)
            {
                fillCombox();
            }
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView_flights.Rows.Clear();
            String dest = cbxDestination.SelectedItem.ToString();
            for (int i = 0; i < FlightsList[dest].Count; ++i)
            {
                GridView_flights.Rows.Add(FlightsList[dest].ElementAt(i).FlightNo, FlightsList[dest].ElementAt(i).arrivalDate);
            }
        }

        private void lblDestination_Click(object sender, EventArgs e)
        {

        }

        private void btn_backToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addFlight_Click(object sender, EventArgs e)
        {
            AddFlightForm add = new AddFlightForm(PassengersList,FlightsList);
            add.Show();
        }

       

       
    }
}
