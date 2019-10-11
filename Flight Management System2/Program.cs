using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

public class Passenger
{
    public string Name;
    public string Phone;
    public string FlightNo;

    public Passenger()
    {
        Name = null;
        Phone = null;
        FlightNo = null;

    }
    public Passenger(string name, string phone, string flightNo)
    {
        Name = name;
        Phone = phone;
        FlightNo = flightNo;
    }
    public void update(Passenger passenger)
    {
        this.FlightNo = passenger.FlightNo;
        this.Name = passenger.Name;
        this.Phone = passenger.Phone;
    }

   
}
public class Flight
{
    //must be public to be seen in the form
    public string FlightNo;
    public string Destination;
    public string arrivalDate;


    public static  int FlightNo_len = 5;
    public static int Destination_len = 15;
    public static int arrivalDate_len = 10;


    public Flight()
    {

        FlightNo = null;
        Destination = null;
        arrivalDate = null;
    }

    public Flight(string flightNo, string dest, string Date)
    {
        FlightNo = flightNo;
        Destination = dest;
        arrivalDate = Date;
    }

}

namespace Flight_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
          
        }
    }
}
