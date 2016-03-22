using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AirPort
{
    public class PassengerList
    {
        public List<Passenger> Passengers = new List<Passenger>();

        public PassengerList()
        {
            this.LoadPassengersData();
        }
        public void LoadPassengersData()
        {
            StreamReader sr = new StreamReader("../../Passengers.txt");
            string data = sr.ReadLine();

            while (data != null)
            {
                //Console.WriteLine(data);
                string [] values = data.Split(',');
                DateTime tempDate;
                string [] timeData = values[5].Split('/');

                Passenger tempPassenger = new Passenger();

                tempPassenger._flightNumber = Int32.Parse(values[0]);
                tempPassenger._firstName = values[1];
                tempPassenger._secondName = values[2];
                tempPassenger._nationality = values[3];
                tempPassenger._passport = Int32.Parse(values[4]);      
                tempDate = new DateTime(Int32.Parse(timeData[0]), Int32.Parse(timeData[1]), Int32.Parse(timeData[2]));
                tempPassenger._dateOfBirth = tempDate;
                tempPassenger._sex = values[6];
                tempPassenger._ComfortClass = values[7];

                Passengers.Add(tempPassenger);

                data = sr.ReadLine();
            }
        }

        public void ShowPassengers()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            foreach (Passenger item in Passengers)
            {
                Console.WriteLine(@"{0,3}{1,10}{2,10}{3,10}{4,10}{5,6}/{6,2}/{7,2}{8,8}{9,9}", item._flightNumber, item._firstName, item._secondName,
                item._nationality, item._passport, item._dateOfBirth.Year, item._dateOfBirth.Month, item._dateOfBirth.Day, item._sex.ToString(), item._ComfortClass);
            }
            Console.ForegroundColor = ConsoleColor.White;
                        
        }
    }

    //constructor


    //method of input

    //method of deleting

    //method of editing
}
