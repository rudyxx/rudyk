using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Exception;

namespace lab_1_3_1
{
    class MyArray
    {
        int[] arr;

        public void Assign(int[] arr, int size)
        {
            // 5) add block try (outside of existing block try)
            try
            {
                try
                {
                    this.arr = new int[size];
                    for (int i = 0; i < arr.Length; i++)
                        this.arr[i] = arr[i] / arr[i + 1];

                    // 1) assign some value to cell of array int_array, which index is out of range
                    this.arr[size+100] = 100;


                    // 7) use unchecked to assign result of operation 1000000000 * 100 
                    // to last cell of array
                    unchecked
                    {
                        this.arr[size - 1] = 1000000000 * 100;
                    }


                }
                // 2) catch exception index out of rage
                catch (IndexOutOfRangeException ex)
                {
                    // output message 
                    Console.WriteLine("IndexOutOfRangeException!***");
                }

                // 4) catch devision by 0 exception
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("DivideByZeroException!***");
                }

                // 6) add catch block for null reference exception of outside block try  
                // change the code to execute this block (any method of any class)
                catch(NullReferenceException ex)
                {
                    Console.WriteLine("NullReferenceException!***");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("some text to fill outer catch-block and message: ", ex.Message);
            }

        }
    }
}
