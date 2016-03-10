using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_2
{
    public sealed class Derived : Base<Derived>
    {
        public  Derived()
        {
            Console.WriteLine("Derived constructor worked");
        }
    }
}
