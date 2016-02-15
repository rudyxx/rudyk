using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2_2
{
    class Box
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public char symbol { get; set; }

        long multiplier;
        string mess;

        public string message {
            get 
            {
                return mess;
            }
            set 
            { 
                string temp = value;
                if (temp.Length > width)
                {
                    mess = temp.Substring(0, width - 2);
                }
                else
                    mess = value;
            }
        }

        
        public void Draw()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < height+y; i++)
            {
                for (int j = 0; j < width+x; j++)
                {
                    if ((i == y && j >= x) || (i == y + height - 1 && j >= x) || (i >= y && j == x + width - 1) || (i >= y && j == x ))
                    {
                            Console.Write(symbol);                       
                    }
                    else if((i == y+(height / 2)) && (j == x+ ((width / 2) - (message.Length/2))))
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        j += message.Length-1;
                        for (int k = 0; k < message.Length; k++)
                        {
                            Console.Write(message[k]);
                        }
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public void WriteMessage()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            multiplier = Math.BigMul(width, height);
            Console.WriteLine("Math.BigMul(width, height) = {0}", multiplier);
            
        }

    }
}
