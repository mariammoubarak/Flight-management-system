using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Flight_Management_System
{
    public partial class StartForm : Form
    {
        static Dictionary<String, Passenger> PassengersList = new Dictionary<String, Passenger>();
        static Dictionary<String, List<Flight>> FlightsList = new Dictionary<String, List<Flight>>();

      
        public StartForm()
        {
            InitializeComponent();
           FlightsList = readFly();
            PassengersList = readPass();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            PassengersForm passengerForm = new PassengersForm(PassengersList,FlightsList);
            passengerForm.Show();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {


            FlightsForm flightForm = new FlightsForm(FlightsList, PassengersList);
            flightForm.Show();
        }

       
        public static Dictionary<String, List<Flight>> readFly()
        {
            FileStream F = new FileStream("Flights.txt", FileMode.OpenOrCreate);
            StreamReader SR = new StreamReader(F);

            Flight fly =null;
            string line = null;
            string[] Records = null;
            List<Flight> flights=null;

            while (SR.Peek() != -1)
            {
                line = SR.ReadToEnd();
                Records = line.Split('#');
            }
            for (int i = 0; i < Records.Length-1; ++i)
            {
                fly = new Flight();
                fly.FlightNo = Records[i].Substring(0, Flight.FlightNo_len );
                fly.Destination = Records[i].Substring(Flight.FlightNo_len, Flight.Destination_len );
                fly.arrivalDate = Records[i].Substring(Flight.Destination_len + Flight.FlightNo_len, Flight.arrivalDate_len );
                if (!FlightsList.ContainsKey(fly.Destination))
                {
                    flights = new List <Flight>();
                    FlightsList.Add(fly.Destination, flights);
                }
                FlightsList[fly.Destination].Add(fly);
            }
            SR.Close();
            F.Close();
            return FlightsList;
        } 
        public static Dictionary<String, Passenger> readPass()
        {
            FileStream F = new FileStream("Passengers.txt", FileMode.OpenOrCreate);
            StreamReader SR = new StreamReader(F);


            Passenger pass = null;

            const int Record_len = 50;

            string line = null;
            string[] Records = null;
            string[] temp;

            while (SR.Peek() != -1)
            {
                line = SR.ReadToEnd();
                Records = new string[(line.Length / Record_len)];
            }


            int rec_count = 0;
            for (int i = 0; i < line.Length - 1; i += Record_len)
            {
                Records[rec_count] = line.Substring(i, Record_len);

                temp = Records[rec_count].Split('@');
                pass = new Passenger();
                pass.Name = temp[0];
                pass.Phone = temp[1];
                pass.FlightNo = temp[2].Substring(0, Flight.FlightNo_len);
                PassengersList.Add(pass.Name, pass);
                ++rec_count;


            }


            SR.Close();
            F.Close();

            return PassengersList;
        }
        public static void writeFly(Dictionary<String, List<Flight>> flightlist)
        {
            FileStream F = new FileStream("Flights.txt", FileMode.Truncate);
            F.Close();
            F = new FileStream("Flights.txt", FileMode.Append);

            StreamWriter SW = new StreamWriter(F);

            char[] ch=null;
            string str=null;

            
            for (int i = 0; i < FlightsList.Count; ++i)
            {
                for (int k = 0; k < flightlist.ElementAt(i).Value.Count; ++k)
                { 
                str = flightlist.ElementAt(i).Value.ElementAt(k).FlightNo;
                ch = new char[Flight.FlightNo_len];
                str.CopyTo(0, ch, 0, str.Length);
                for (int j = str.Length; j < ch.Length; ++j)
                {
                    ch[j] = '\0';
                }
                SW.Write(ch);

                str = flightlist.ElementAt(i).Value.ElementAt(k).Destination;
                ch = new char[Flight.Destination_len];
                str.CopyTo(0, ch, 0, str.Length);
                for (int j = str.Length; j < ch.Length; ++j)
                {
                    ch[j] = '\0';
                }
                SW.Write(ch);

                str = flightlist.ElementAt(i).Value.ElementAt(k).arrivalDate;
                ch = new char[Flight.arrivalDate_len];
                str.CopyTo(0, ch, 0, str.Length);
                for (int j = str.Length; j < ch.Length; ++j)
                {
                    ch[j] = '\0';
                }
                SW.Write(ch);

                SW.Write("#");
                }
            }
            SW.Close();
            F.Close();

        }
        public static void writePass(Dictionary<String, Passenger> PassengerList)
        {
           FileStream  F = new FileStream("Passengers.txt", FileMode.Truncate);
           F.Close();
           F = new FileStream("Passengers.txt", FileMode.Append);
           StreamWriter SW = new StreamWriter(F);

            int Record_len = 50;
            String tmp;
            char[] ch=null;

            for (int i = 0; i < PassengerList.Count; ++i)
           {
               tmp = PassengerList.ElementAt(i).Value.Name + "@" + PassengerList.ElementAt(i).Value.Phone + "@" + PassengerList.ElementAt(i).Value.FlightNo;


               ch = new char[Record_len];
                tmp.CopyTo(0, ch, 0, tmp.Length);
                for (int j = tmp.Length; j < ch.Length; ++j)
                {
                    ch[j] = '\0';
                }
                SW.Write(ch);
                
           }

            SW.Close();
            F.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

    }

}