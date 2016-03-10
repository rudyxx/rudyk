using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_2
{
    public class Base_public_field<T> where T : new()
    {
        private T _instance;
        public T Instance
        {
            get
            {
                Console.WriteLine("Public field");
                _instance = new T();
                return _instance;
            }
        }

        static Base_public_field()
        {
            Console.WriteLine("Base_public_field<T> constructor worked");
            T intern = new T();
        }

    }
}
