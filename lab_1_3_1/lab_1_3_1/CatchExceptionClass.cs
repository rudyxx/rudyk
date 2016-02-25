using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_3_1
{
    class CatchExceptionClass
    {
        public void CatchExceptionMethod()
        {
            try
            {
                MyArray ma = new MyArray();

                // 3) replace second elevent of array by 0
                //what is elevent?


                int[] arr = new int[4] { 1, 4, 8, 5 };
                ma.Assign(arr, 4);

                arr[1] = 0;
                arr[10] = 0;
                

            }

                // 8) catch all other exceptions here
            catch(Exception ex)
            {
                // 9) print System.Exception properties:
                // HelpLink, Message, Source, StackTrace, TargetSite
                Console.WriteLine("ex.HelpLink - {0}", ex.HelpLink);
                Console.WriteLine("ex.Message - {0}", ex.Message);
                Console.WriteLine("ex.Source - {0}", ex.Source);
                Console.WriteLine("ex.StackTrace - {0}", ex.StackTrace);
                Console.WriteLine("ex.TargetSite - {0}", ex.TargetSite);

            }

            // 10) add finally block, print some message
            // explain features of block finally
            finally
            {
                Console.WriteLine("Hello! This is finally bock, he doing nothing, just exist");
            }

        }
    }
}
