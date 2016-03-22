using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{

    public enum FlightStatus { checkIn, gateClosed, arrived, departedAt, 
                        unknown, canceled, expectedAt, delayed, inFlight}

    public class FlightInfo
    {
        public DateTime dateTime { get; set; }
        public int flyNumber { get; set; }
        public string cityPort { get; set; }
        public int terminal { get; set; }
        public FlightStatus FlightStatus { get; set; }
        public int gate { get; set; }

        public FlightInfo() { }

        public FlightInfo(DateTime dateTime, int flyNumber, string cityPort, int terminal,FlightStatus FlightStatus,  int gate)
        {
            this.dateTime = dateTime;
            this.flyNumber = flyNumber;
            this.cityPort = cityPort;
            this.terminal = terminal;
            this.FlightStatus = FlightStatus;
            this.gate = gate;
        }
    }
}
