using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_2
{
    public class Base_publ<T> where T: new()
    {
        private T _instance;
        public  T Instance
        {
            get
            {              
                Console.WriteLine("some public field");
                _instance = new T();
                return _instance;
            }
        }
        
        static Base_publ()
        {
            T intern = new T();
            Console.WriteLine("static constructor. I did as stated in the task");
        }
    }
}
