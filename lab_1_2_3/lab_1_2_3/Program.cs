using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money ob1 = new Money(100, CurrencyTypes.UAH);
            Money ob2 = new Money(200, CurrencyTypes.UAH);

            Console.WriteLine("ob1.Amount = {0},\nob1.CurencyType = {1}", ob1.Amount, ob1.CurrencyType);
            Console.WriteLine("ob2.Amount = {0},\nob2.CurencyType = {1}", ob2.Amount, ob2.CurrencyType);
            // 11) do operations
            // add 2 objects of Money
            ob2 += ob1;
            Console.WriteLine("ob2 += ob1  :  {0}", ob2.Amount);

            // add 1st object of Money and double
            ob1 += 12.3;
            Console.WriteLine("ob1 += 12.3  :  {0}", ob1.Amount);

            // decrease 2nd object of Money by 1 
            ob2--;
            Console.WriteLine("ob2--  :  {0}", ob2.Amount);

            // increase 1st object of Money
            ob1 *= 3;
            Console.WriteLine(" ob1 *= 3  :  {0}", ob1.Amount);

            // compare 2 objects of Money

            Console.WriteLine(" compare 2 objects of Money  :  {0} and {1}", ob1.Amount, ob2.Amount);
            if(ob1 > ob2)
                Console.WriteLine("ob1 > ob2");
            else
                Console.WriteLine("ob1 is not bigger than ob2");

            // compare 2nd object of Money and string

            string strToComp = "100";
            Console.WriteLine("compare 2nd object of Money and string {0} and {1}", ob2.Amount, strToComp);
            if(string.Equals(strToComp,ob2))
            {
                Console.WriteLine("{0} == {1}", strToComp, ob2.Amount);
            }
            else
                Console.WriteLine("they are not even");
           
            // check CurrencyType of every object
            if(ob1)
            {
                Console.WriteLine("***strange CurenceType*** {0} > 0 ", ob1.Amount );
            }
            else

                Console.WriteLine("***strange CurenceType*** {0} > 0 ", ob1.Amount);
        
            // convert 1st object of Money to string
            Console.WriteLine("convert 1st object of Money to string");
            string str1 = (string)ob1;
            Console.WriteLine(str1);
        }
    }
}
