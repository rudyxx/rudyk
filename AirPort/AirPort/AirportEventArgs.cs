using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort
{
    class AirportEventArgs: EventArgs
    {
        public string accident;

        AirportEventArgs(string mess)
        {
            accident = mess;
        }
    }
}
