using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box();
            //let's skip the boring input
            b.x = 10;
            b.y = 10;
            b.height = 16;
            b.width = 20;
            b.symbol = '*';
            b.message = "Hello! Let me introduce myself!  My name is... oh God,why am I fooling myself, who cares about my name?";
            b.Draw();


            b.WriteMessage();
            Console.ReadKey();
        }
    }
}
