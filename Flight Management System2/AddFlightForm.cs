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
    public partial class AddFlightForm : Form
    {
        Dictionary<String, Passenger> PassengersList = new Dictionary<String, Passenger>();
        Dictionary<String, List<Flight>> FlightsList = new Dictionary<String, List<Flight>>();
        public AddFlightForm(Dictionary<String, Passenger> PassengersList, Dictionary<String, List<Flight>> FlightsList)
        {
            InitializeComponent();
            this.PassengersList = PassengersList;
            this.FlightsList = FlightsList;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_passName.Text=="" || txt_passPhone.Text=="")
            {
                MessageBox.Show("Please enter the required Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (PassengersList.ContainsKey(txt_passName.Text))
            {
                MessageBox.Show("This Name already exists on another flight", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Passenger passenger = new Passenger();
                
                if (txt_passName.Text.Length + txt_passPhone.Text.Length + txt_flightNumber.Text.Length+2>50)
                {
                    MessageBox.Show("Maximum lenght of passenger info is 50", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                passenger.FlightNo = txt_flightNumber.Text;
                passenger.Name = txt_passName.Text;
                passenger.Phone = txt_passPhone.Text;
                PassengersList.Add(passenger.Name, passenger);

            }


            txt_passName.Clear();
            txt_passPhone.Clear();
        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            if (txt_flightNumber.Text=="" || txt_arrivalDate.Text=="" || txt_destination.Text=="")
            {
                MessageBox.Show("Please enter the required Info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (txt_flightNumber.Text.Length > Flight.FlightNo_len)
            {
                MessageBox.Show("Maximum lenght of flight number is " + Flight.FlightNo_len, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_flightNumber.Clear();
            }
            if (txt_destination.Text.Length > Flight.Destination_len)
            {
                MessageBox.Show("Maximum lenght of flight number is " + Flight.Destination_len, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_flightNumber.Clear();
            }

            if (txt_arrivalDate.Text.Length > Flight.arrivalDate_len)
            {
                MessageBox.Show("Maximum lenght of flight number is " + Flight.arrivalDate_len, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_flightNumber.Clear();
            }
            bool found = false;
            char[] ch = new char[Flight.FlightNo_len];
            txt_flightNumber.Text.CopyTo(0, ch, 0, txt_flightNumber.Text.Length);
            for (int j = txt_flightNumber.Text.Length; j < ch.Length; ++j)
            {
                ch[j] = ' ';
            }
            string str =new string (ch);

            for (int i = 0; i < FlightsList.Count; ++i)
            {
                for (int j = 0; j < FlightsList.ElementAt(i).Value.Count; ++j)
                {


                    if (FlightsList.ElementAt(i).Value.ElementAt(j).FlightNo == str)
                    {

                        MessageBox.Show("This Flight already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_flightNumber.Clear();
                        txt_destination.Clear();
                        txt_arrivalDate.Clear();
                        found = true;
                        break;
                    }
                }
                if(found)
                {
                    break;
                }
            }
            if (!found)
            {
                Flight flight = new Flight();
                flight.arrivalDate = txt_arrivalDate.Text;
                flight.Destination = txt_destination.Text;
                flight.FlightNo = txt_flightNumber.Text;

                if (!FlightsList.ContainsKey(flight.Destination))
                {
                    List<Flight> flights = new List<Flight>();
                    FlightsList.Add(flight.Destination, flights);
                }
                FlightsList[flight.Destination].Add(flight);
                StartForm.writePass(PassengersList);
                StartForm.writeFly(FlightsList);

                this.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
