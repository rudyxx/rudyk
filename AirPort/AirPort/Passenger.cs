using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    public class Passenger
    {
        public int _flightNumber { get; set; }
        public string _firstName { get; set; }
        public string _secondName { get; set; }
        public string _nationality { get; set; }
        public int _passport { get; set; }
        public DateTime _dateOfBirth { get; set; }
        public string _sex { get; set; }
        public string _ComfortClass { get; set; }

        public Passenger() { }

        public Passenger(int flightNumber, string firstName, string secondName, string nationality, int passport, DateTime dateOfBirth, string sex, String ComfortClass)
        {
            _flightNumber = flightNumber;
            _firstName = firstName;
            _secondName = secondName;
            _nationality = nationality;
            _passport = passport;
            _dateOfBirth = dateOfBirth;
            _sex = sex;
            _ComfortClass = ComfortClass;
        }
    }



    //constructor

}
