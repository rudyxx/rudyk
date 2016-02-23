using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CatchExceptionClass cec = new CatchExceptionClass();
            cec.CatchExceptionMethod();
            //UnhandledExceptionEventArgs;
            // 11) Make some unhandled exception and study Visual Studio debugger report – 
            // read description and find the reason of exception
        }
    }
}
