using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_2
{
    public class Base<T> where T : new()
    {
        static Base()
        {
            T instance = new T();
            Console.WriteLine("Base constructor worked");
        }
    }
}
