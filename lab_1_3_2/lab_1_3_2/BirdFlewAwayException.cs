﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_3_2
{
    #region Opr1

    public class BirdFlewAwayException : ApplicationException
    {
        public DateTime When { get; set; }
        public string Why { get; set; }

        public BirdFlewAwayException() { }

        public BirdFlewAwayException(string message, string cause, DateTime time)
            : base(message)
        {
            Why = cause;
            When = time;
        }

    }
    #endregion
}
