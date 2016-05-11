using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_1_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadManipulator tManipulator = new ThreadManipulator();
            int[] arr = { 5, 15 };

            Thread thread_for_AddingOne1 = new Thread(tManipulator.AddingOne);
            Thread thread_for_AddingOne2 = new Thread(tManipulator.AddingOne);
            Thread thread_for_AddingCustom = new Thread(tManipulator.AddingCustomValue);
            Thread thread_for_Stop = new Thread(tManipulator.Stop);


            thread_for_Stop.IsBackground = true;

            thread_for_AddingOne1.Start(10);
            thread_for_AddingOne2.Start(20);
            thread_for_AddingCustom.Start(arr);
            thread_for_Stop.Start();

            thread_for_AddingOne1.Join();
            thread_for_AddingOne2.Join();
            thread_for_AddingCustom.Join();
            thread_for_Stop.Join();
        }
    }
}
