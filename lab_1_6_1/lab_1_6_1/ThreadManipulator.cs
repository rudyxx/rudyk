using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_1_6_1
{
    class ThreadManipulator
    {
        ConsoleKey key;
        object block = new object();

        public void AddingOne(object obj)
        {
                Monitor.Enter(block);
                int counter = 1;
                int tempNum = (int) obj;
                while (counter <= 100 && key != ConsoleKey.Q)
                {
                    if (counter % tempNum == 0)
                        Console.WriteLine("AddingOne Divisible by {0}, courrent value {1}", tempNum, counter);
                    counter++;
                    Thread.Sleep(250);
                }
                Console.WriteLine("thread is ended");
                Monitor.Exit(block);
            

        }

        public void AddingCustomValue(object obj)
        {
            int [] tempNum = (int[])obj;
            int divisibleBy = tempNum[0];
            int step = tempNum[1];

            int counter = 1;
            while (counter <= 100 && key != ConsoleKey.W)
            {
                if ((counter % step) == 0)
                {
                    Console.WriteLine("Divisible by {0}, courrent value {1}", divisibleBy, counter );                    
                }
                Thread.Sleep(250);
                counter++;
            }
                 Console.WriteLine("AddingCustomValue thread is ended");
        }

        public void Stop()
        {
            while(key != ConsoleKey.E)
            {
                key = Console.ReadKey().Key;
                Console.WriteLine("Stop() thread is ended");
                Thread.Sleep(500);
            }
        }
    }
}
