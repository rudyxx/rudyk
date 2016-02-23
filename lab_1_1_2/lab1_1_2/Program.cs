using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, sb, sh, ush, i, ui, l, ul, de, fl, do
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true; // bool cant be  = 1;
            char ch = 'c'; 
            byte by = 250;
            sbyte sb = 127;
            short sh = 10000;
            ushort ush = 25;
            int i = -223;
            uint ui = 300;
            long l = 300;
            ulong ul = 300;
            decimal de = 100000.6M;
            float fl = -33;
            //double do = -33.1;    //compilation error. C# Keywords - do

            //2) declare constants of int and double. Try to change their values.
            int someInt = 100;
            double someDouble = 100.0D;

            someInt = 200;
            someDouble = 300.0D;

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var vI = 20;
            var vD = 20.5;

            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and do. Is it possible?
            System.Int32 sIV = i;
            //System.Double sDV = do; // C# Keywords - do

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //int i; //can not be declared in this scope
                //char ch;
                //double do;  //compilation error. C# Keywords - do. nothing changed from 1)


                // 6) change values of variables from 1)
                i = 500; //its OK, it is possible;
            }

            // 7)check values of variables from 1). Are they changed? Think, why
            Console.WriteLine("i = {0}", i); 
            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 
            // Fix compilation errors (in case of impossible conversion commemt that line).
            i = (int)ch;
            //boo = (bool)sh; //you cant convert bool to short
            //do = l; //error
            fl = ch;
            //de = do; error
            by = (byte)ui; //danger! posible lose of data
            ul = (ulong)sb;

            // 9) and reverse conversion with fixing compilation errors.

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            int? nullInt = null;
            //i = null; //imposible cuz  i  isn't nullable.
        }
    }
}
