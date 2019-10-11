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
    public partial class PassengersForm : Form
    {
         Dictionary<String, Passenger> PassengersList = new Dictionary<String, Passenger>();
        Dictionary<String, List<Flight>> FlightsList = new Dictionary<String, List<Flight>>();


       
        public PassengersForm(Dictionary<String, Passenger> PassengersList, Dictionary<String, List<Flight>> FlightsList)
        {
            InitializeComponent();
            this.PassengersList = PassengersList;
            this.FlightsList = FlightsList;
            if (cbx_flight.Items.Count == 0)
            {
                fillCombox();
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            cbx_flight.Visible = false;
            cbx_Date.Visible = false;
            cbx_SearchPass.Visible = false;
            btn_update.Visible = false;
            lbl_flightNo.Visible = false;
            lbl_Phone.Visible = false;
            txt_flight.Visible = false;
            txt_phone.Visible = false;
            GridView_Passengers.Visible = true;
            GridView_Passengers.Rows.Clear();
           for (int i=0;i< PassengersList.Count; ++i)
           {
               GridView_Passengers.Rows.Add(PassengersList.ElementAt(i).Key, PassengersList.ElementAt(i).Value.Phone, PassengersList.ElementAt(i).Value.FlightNo);
           }
           
           
        }
        void fillCombox()
        {
            for (int i = 0; i < PassengersList.Count; ++i)
            {
                if (!cbx_flight.Items.Contains(PassengersList.ElementAt(i).Value.FlightNo))
                {
                    cbx_flight.Items.Add(PassengersList.ElementAt(i).Value.FlightNo);
                }
            }
            for (int i = 0; i < FlightsList.Count; ++i)
            {
                for (int j = 0; j < FlightsList.ElementAt(i).Value.Count; ++j)
                {
                    if (!cbx_Date.Items.Contains(FlightsList.ElementAt(i).Value.ElementAt(j).arrivalDate))
                    {
                        cbx_Date.Items.Add(FlightsList.ElementAt(i).Value.ElementAt(j).arrivalDate);
                    }
                }
            }
            for (int i = 0; i < PassengersList.Count; ++i)
            {
                    cbx_SearchPass.Items.Add(PassengersList.ElementAt(i).Key);
            }

        }
        private void cbx_flight_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView_Passengers.Rows.Clear();
            String FlightNo = cbx_flight.SelectedItem.ToString();
            for (int i = 0; i < PassengersList.Count; ++i)
            {
                if (FlightNo == PassengersList.ElementAt(i).Value.FlightNo)
                {
                    GridView_Passengers.Rows.Add(PassengersList.ElementAt(i).Key, PassengersList.ElementAt(i).Value.Phone, PassengersList.ElementAt(i).Value.FlightNo);

                }
            }
        }

        private void cbx_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView_Passengers.Rows.Clear();
            String date = cbx_Date.SelectedItem.ToString();

            for (int i = 0; i < FlightsList.Count; ++i)
            {
                for (int j = 0; j < FlightsList.ElementAt(i).Value.Count; ++j)
                {
                    if (date == (FlightsList.ElementAt(i).Value.ElementAt(j).arrivalDate))
                    {
                        for (int k = 0; k < PassengersList.Count; ++k)
                        {
                            String fFlightNo = FlightsList.ElementAt(i).Value.ElementAt(j).FlightNo;
                            String pFlightNo = PassengersList.ElementAt(k).Value.FlightNo;
                            if (fFlightNo == (pFlightNo))
                            {
                                GridView_Passengers.Rows.Add(PassengersList.ElementAt(k).Key, PassengersList.ElementAt(k).Value.Phone, PassengersList.ElementAt(k).Value.FlightNo);
                            }
                        }
                    }
                }
            }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            // to update data 
            Passenger tmp = new Passenger();
            bool isPhoneUpdate = true;
            bool isFlightUpdate = true;
            bool both = true;
            tmp.Name = cbx_SearchPass.SelectedItem.ToString();
            tmp.Phone = txt_phone.Text;
            tmp.FlightNo = txt_flight.Text;

            if (PassengersList.ContainsKey(tmp.Name))
            {
                if (tmp.Phone=="")
                {
                    tmp.Phone = PassengersList[tmp.Name].Phone;
                    isPhoneUpdate = false;
                }
                if (tmp.FlightNo == "")
                {
                    tmp.FlightNo = PassengersList[tmp.Name].FlightNo;
                    isFlightUpdate = false;
                }
                if (!isFlightUpdate && !isPhoneUpdate)
                {
                    both = false;
                }
                PassengersList[tmp.Name].update(tmp);
                if (both)
                {
                    MessageBox.Show("Updated successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(isPhoneUpdate && !isFlightUpdate)
                {
                    MessageBox.Show("Phone is Updated successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!isPhoneUpdate && isFlightUpdate)
                {
                    MessageBox.Show("Flight Number is Updated successfully ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Update occured ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show(" No passenger with this name " , "Warrning",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            StartForm.writePass(PassengersList);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_searchByDate_Click(object sender, EventArgs e)
        {
            cbx_flight.Visible = false;
            cbx_Date.Visible = true;
            cbx_SearchPass.Visible = false;
            btn_update.Visible = false;
            lbl_flightNo.Visible = false;
            lbl_Phone.Visible = false;
            txt_flight.Visible = false;
            txt_phone.Visible = false;
            GridView_Passengers.Visible = true;
        }

        private void btn_SearchByFlightNo_Click(object sender, EventArgs e)
        {
            cbx_flight.Visible = true;
            cbx_Date.Visible = false;
            cbx_SearchPass.Visible = false;
            btn_update.Visible = false;
            lbl_flightNo.Visible = false;
            lbl_Phone.Visible = false;
            txt_flight.Visible = false;
            txt_phone.Visible = false;
            GridView_Passengers.Visible = true;
        }

        private void btn_updatePassInfo_Click(object sender, EventArgs e)
        {
            cbx_flight.Visible = false;
            cbx_Date.Visible = false;
            cbx_SearchPass.Visible = true;
            btn_update.Visible = true;
            lbl_flightNo.Visible = true;
            lbl_Phone.Visible = true;
            txt_flight.Visible = true;
            txt_phone.Visible = true;
            GridView_Passengers.Visible = false;
        }

       

       
    }
}
