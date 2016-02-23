using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2_4
{
    interface IMorse_crypt
    {
        string crypt(string word);
        string decrypt(string[] signal);
    }
}
