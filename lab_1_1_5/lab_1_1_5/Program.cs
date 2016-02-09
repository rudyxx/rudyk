using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab_1_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    //do something
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                        try
                        {
                            a = (int)uint.Parse(Console.ReadLine());
                            switch (a)
                            {
                                case 2:
                                    My_Binary();
                                    Console.WriteLine("");
                                    break;
                                case 1:
                                    My_strings();
                                    Console.WriteLine("");
                                    break;
                                case 3:
                                    My_music();
                                    Console.WriteLine("");
                                    break;
                                case 4:
                                    Morse_code();
                                    Console.WriteLine("");
                                    break;

                                default:
                                    Console.WriteLine("Exit");
                                    break;
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error");
                        }
                    }

                    //end do something
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        #region ToFromBinary
        static void My_Binary()
        {
            int someN;
            string someStr = "0";
            Console.WriteLine("Type  positive number");
            someN = (int)uint.Parse(Console.ReadLine());
            if (someN > 0)
            {
                long tempHold;
                char[] binaryArray;
                someStr = "";
                while (someN > 0)
                {
                    tempHold = someN % 2;
                    someStr += tempHold;
                    someN = someN / 2;
                }
                binaryArray = someStr.ToCharArray();
                Array.Reverse(binaryArray);
                someStr = new string(binaryArray);
            }

            Console.WriteLine(" Binary a = " + someStr);
        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            int numF, NumS;
            string firstStr, secondStr, firstAndSecondStr, anotherString;
            long fStrLen, sStrLen, minLen;

            Console.WriteLine("enter first positive int");
            numF = (int)uint.Parse(Console.ReadLine());

            Console.WriteLine("enter second positive int");
            NumS = (int)uint.Parse(Console.ReadLine());

            {
                firstStr = "";
                for (int ii = 0; ii < numF; ii++)
                {
                    firstStr += "1";
                }
                Console.WriteLine(firstStr);

                secondStr = "";
                for (int j = 0; j < NumS; j++)
                {
                    secondStr += "1";
                }
                Console.WriteLine(secondStr);

                firstAndSecondStr = firstStr + "#" + secondStr;
                fStrLen = firstStr.Length;
                sStrLen = secondStr.Length;

                if (fStrLen == 0)
                    anotherString = secondStr;
                else if (sStrLen == 0)
                    anotherString = firstStr;
                else
                {
                    if (fStrLen < sStrLen)
                        minLen = fStrLen;
                    else
                        minLen = sStrLen;
                    anotherString = firstAndSecondStr;
                    for (int i = 1; i <= minLen; i++)
                    {
                        anotherString = anotherString.Replace("1#1", "#");
                    }
                    anotherString = anotherString.Trim(new Char[] { '#' });


                }
                Console.WriteLine("unary |a-b|= " + anotherString);
                int IntResult = 0;
                for (int k = 1; k <= anotherString.Length; k++)
                {
                    IntResult += 1;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("decimal |a-b|= " + IntResult);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            string massage = "";

            Console.Write("Enter your massage: ");
            massage = Console.ReadLine();

            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};

            foreach (char c in massage.ToCharArray())
            {

                string result = "";
                for (int i = 0; i < 36; i++)
                {
                    if (Dictionary_arr[0, i] == c.ToString())
                    {
                        result = Dictionary_arr[1, i];
                        result = result.Trim();
                    }
                }


                foreach (char morseIt in result.ToCharArray())
                {
                    if (morseIt == '.')
                        Console.Beep(1000, 250);
                    else
                        Console.Beep(1000, 750);
                }
                System.Threading.Thread.Sleep(50);
            }
        }

        #endregion
    }
}
