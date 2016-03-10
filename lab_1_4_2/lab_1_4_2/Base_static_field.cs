using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_2
{
    class Base_static_field<T> where T : new()
    {
        private static T _instance;
        public static T instance
        {
            get
            {
                Console.WriteLine("get of static field");
                _instance = new T();
                return _instance;
            }
        }

        protected Base_static_field()
        {
            Console.WriteLine("Base_static_field protected constructor worked");
        }
    }
}
