using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AirPort
{
    public class FlightStats
    {
        List<FlightInfo> Arrival;
        List<FlightInfo> Departure;

        public FlightStats()
        {
            Arrival = new List<FlightInfo>();
            Departure = new List<FlightInfo>();

            LoadFlights(ref Arrival, "../../FlightsArrival.txt");
            LoadFlights(ref Departure, "../../FlightsDeparture.txt");
        }

        public void LoadFlights(ref List<FlightInfo> FlightList, string file)
        {
            StreamReader sr = new StreamReader(file);
            string data = sr.ReadLine();

            while (data != null)
            {
                //Console.WriteLine(data);
                string[] values = data.Split(',');
                string[] timeData = values[0].Split('/');
                DateTime tempDate = new DateTime(Int32.Parse(timeData[0]), Int32.Parse(timeData[1]), Int32.Parse(timeData[2]), Int32.Parse(timeData[3]), Int32.Parse(timeData[4]), Int32.Parse(timeData[5]));
                FlightList.Add(new FlightInfo(tempDate, Int32.Parse(values[1]), values[2], Int32.Parse(values[3]), (FlightStatus)Int32.Parse(values[4]), Int32.Parse(values[5])));
                
                data = sr.ReadLine();
            }
        }
        public void ShowArrivalFlights()
        {
            Console.WriteLine("");
            foreach (FlightInfo item in Arrival)
            {
                Console.WriteLine("Arrival:   {0}/{1}/{2,2} {3,3}:{4,2}:{5,2} {6,4} {7,10} {8,4} {9,12} {10,4} ", item.dateTime.Year, item.dateTime.Month, item.dateTime.Day,
                    item.dateTime.Hour, item.dateTime.Minute, item.dateTime.Second, item.flyNumber, item.cityPort, item.terminal, item.FlightStatus.ToString(), item.gate);
            }

        }

        public void ShowDepartureFlights()
        {
            foreach (FlightInfo item in Departure)
            {
                Console.WriteLine("Departure: {0}/{1}/{2,2} {3,3}:{4,2}:{5,2} {6,4} {7,10} {8,4} {9,12} {10,4} ", item.dateTime.Year, item.dateTime.Month, item.dateTime.Day,
                    item.dateTime.Hour, item.dateTime.Minute, item.dateTime.Second, item.flyNumber, item.cityPort, item.terminal, item.FlightStatus.ToString(), item.gate);
            }
        }

        public void AddArrivalFlight(DateTime datetime, )
        {
            Arrival.Add()
        }
    }

    
}
