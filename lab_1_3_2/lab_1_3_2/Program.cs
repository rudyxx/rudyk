﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observation titmouse flight");
            Bird My_Bird = new Bird("Titmouse", 20);
            int ii;
            char rdk;
            try
            {
                do
                {
                    try
                    {
                        Console.WriteLine(@"Enter your choise
                1. Array overflow exception  
                2. Throw my exception
                3. user exception
                                    ");
                        uint i = uint.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                int exGet = My_Bird.FlySpeed[10];
                                break;
                            case 2:
                                throw new System.Exception("We throw some exception!");
                            case 3:
                                for (ii = 0; ii < My_Bird.FlySpeed[My_Bird.FlySpeed.Length-1]; ii++)
                                {
                                    My_Bird.FlyAway(ii);
                                }
                                break;
                            default:
                                break;
                        }



                    }
                    catch (BirdFlewAwayException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.When);
                        Console.WriteLine(e.Why);

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("CLS exception: Message -  " + e.Message + " Source - " + e.Source);

                    }
                    finally
                    {
                        Console.WriteLine("For next step ...");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;


                    rdk = Console.ReadKey().KeyChar;
                } while (rdk != ' ');

            }
            catch (Exception mn)
            {

            }


        }

    }
}
