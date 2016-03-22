using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    public class Program
    {


        static void Main(string[] args)
        {
            FlightStats AirportFlight = new FlightStats();
            PassengerList AirportPassengers = new PassengerList();
            PriceList AirportPriceList = new PriceList();


            int UserChoice;
            while (true)
            {
                Console.WriteLine(@"
            1. Airline flight inforation
            2. Price list with class prices
            3. Passengers list
            Enter your choice:");
                UserChoice = int.Parse(Console.ReadLine());
                switch (UserChoice)
                {
                    case 1:
                        AirportFlight.ShowArrivalFlights();
                        AirportFlight.ShowDepartureFlights();
                        break;
                    case 2:
                        break;
                    case 3:
                        AirportPassengers.ShowPassengers();
                        break;
                    default:
                        break;
                }
                //Console.WriteLine("Enter your choice:");
            }
        }

        
    }
}
