using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. factorial calculation
            4. Guess the Number*%$!
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                case 4:
                    GuesstheNumber();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        //RV: It works. But the user has to do all the steps until he knows result, although sombody may be eaten earlier.
        //RV: Consider checking the right decesion on every step.
        static void Farmer_puzzle()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            //showing user options
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8\n");

            //asking user to make input
            Console.WriteLine("Make you choise from 1 - 8!");
            int curNum = 0;
            string playerChoice = "";
            
            //cheking his input
            for(int i = 0; i < 7; i++)
            {
                //is it a number?
                if (!int.TryParse(Console.ReadLine(), out curNum))
                {
                    Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                }

                //is this number in correct diapason?
                if (curNum >= 1 && curNum <= 8)     
                {
                    playerChoice += curNum.ToString();
                }
                else
                {
                    Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                    i--;
                    continue;
                }
                Console.WriteLine(playerChoice);
            }

            if(playerChoice == "3827183" || playerChoice == "3817283")
            {
                Console.WriteLine("*****  Good job, you have succeeded!  *****");
            }
            else
            {
                Console.WriteLine("\n*****  Unfortunately someone ate :'(  *****\n");
            }
        }
        #endregion

        #region calculator
        static void Calculator()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            int choice, num1, num2;
            double result;
            while (true)
            {

                Console.WriteLine(@"Select the arithmetic operation:
                1. Multiplication 
                2. Divide 
                3. Addition 
                4. Subtraction
                5. Exponentiation 
                0. Quit");
                Console.WriteLine("make your dicision: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("!!!!! You did wrong input. press 0 - 5 button !!!!!");
                    continue;
                }

                //is this number in correct diapason?
                if (choice >= 0 && choice <= 5)     
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first number");
                            if (!int.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            Console.WriteLine("Enter second number");
                            if (!int.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            result = num1 * num2;
                            Console.WriteLine("Result = " + result);
                            break;
                        case 2:
                            Console.WriteLine("Enter first number");
                            if (!int.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            Console.WriteLine("Enter second number");
                            if (!int.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            result = num1 / num2;
                            Console.WriteLine("Result = " + result);
                            break;
                        case 3:
                            Console.WriteLine("Enter first number");
                            if (!int.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            Console.WriteLine("Enter second number");
                            if (!int.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            result = num1 + num2;
                            Console.WriteLine("Result = " + result);
                            break;
                        case 4:
                            Console.WriteLine("Enter first number");
                            if (!int.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            Console.WriteLine("Enter second number");
                            if (!int.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            result = num1 * num2;
                            Console.WriteLine("Result = " + result);
                            break;
                        case 5:
                            Console.WriteLine("Enter first number");
                            if (!int.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            Console.WriteLine("Enter second number");
                            if (!int.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("!!!!! You did wrong input. press 1 - 8 button !!!!!");
                            }

                            result = (int)Math.Pow (num1, num2);
                            Console.WriteLine("Result = " + result);
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("!!!!! You did wrong input. press 0 - 5 button !!!!!");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int n = 5; 

            Console.WriteLine("Enter arguments: "); 
            n = int.Parse(Console.ReadLine()); 

            int result = 1; 
            if (n < 0) 
            { 
                throw new ArgumentException(); 
            }

            if (n == 0)
            {
                result = 1;

                Console.WriteLine("factorial =" + result);
                return;
            }

            
            while (n > 1) 
            { 
                result *= n--; 
            }
            Console.WriteLine("factorial = " + result);
        

        }
        #endregion


        #region Guess the Number

        static void GuesstheNumber()
        {
            int maxNum = 100;
            int playerGues = 0;
            int curColor = 1;
            int randomNumber;
            Random rnd = new Random();

            Console.Write("Enter range in which you want guessing from 1 to : ");

            //check is it a number
            if (!int.TryParse(Console.ReadLine(), out maxNum))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!!!!! You did wrong input. You need to enter some number !!!!!", maxNum);
                
            }


            randomNumber = rnd.Next(1, maxNum);

            Console.WriteLine(randomNumber);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your guess in diapasone from 1 to {0}: ", maxNum);

                //check is it a number
                if (!int.TryParse(Console.ReadLine(), out playerGues))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!!! You did wrong input. press 1 - {0} number !!!!!", maxNum);
                    continue;
                }

                //check is this number is correct
                if (playerGues <= 0 || playerGues > maxNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!!! You did wrong input. press 1 - {0} number !!!!!", maxNum);
                    continue;
                }

                if (playerGues > randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("{0} - Too Hight!", playerGues);
                }

                else if (playerGues < randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} - Too Low!", playerGues);
                }
                else if (playerGues == randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} is Right! Congratulations!!", playerGues);
                    break;
                }

            }
        }

        #endregion
    }
}
