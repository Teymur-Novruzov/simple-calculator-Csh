using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TASK1_02_07_2022_Csh
{
    class Program
    {
        static double number_1_final = 0;
        static double number_2_final = 0;
        static double Sum = 0;
        static double Addition()
        {
            Sum = number_1_final + number_2_final;
            return Sum;
        }
        static double Subtraction()
        {
            Sum = number_1_final - number_2_final;
            return Sum;
        }
        static double Multiblication()
        {
            Sum = number_1_final * number_2_final;
            return Sum;
        }
        static double Division()
        {
            switch (number_2_final)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Cannot divide by zero");
                    Thread.Sleep(2000);
                    Sum = 0;
                    return Sum;
                default:
                    Sum = number_1_final / number_2_final;
                    return Sum;
            }      
        }
        static void Enter_numbers()
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write(" Enter first number : ");
            var number_1 = Console.ReadLine();
            switch (double.TryParse(number_1, out number_1_final))
            {
                case true:

                    break;
                case false:
                    Enter_numbers();
                    break;
            }
            Console.WriteLine();
            Console.Write(" Enter second number : ");
            var number_2 = Console.ReadLine();
            switch (double.TryParse(number_2, out number_2_final))
            {
                case true:

                    break;
                case false:
                    Enter_numbers();
                    break;
            }
            Options();
        }
        static void Chec(string choise)
        {
            int choise_final = 0;
            int.TryParse(choise, out choise_final);
            switch (choise_final)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Result : " + Addition()); 
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Result : " + Subtraction());
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(" Result : " + Multiblication());
                    break;
                case 4:
                    switch (Division())
                    {
                        case 0:

                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(" Result : " + Division());
                            break;
                    }                  
                    break;
                default:
                    Options();
                    break;
            }
            Thread.Sleep(2000);
            Enter_numbers();

        }
        static void Options()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" 1 - Addition  ");
            Console.WriteLine(" 2 - Subtraction  ");
            Console.WriteLine(" 3 - Multiblication  ");
            Console.WriteLine(" 4 - Division ");
            Console.WriteLine();
            Console.Write(" Enter choise : ");
            string choise = Console.ReadLine();
            Chec(choise);
        }
        static void Console_informations()
        {
            Console.Title = "Simple Calculator";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
        }
        static void Main(string[] args)
        {
            Console_informations();
            Enter_numbers();
        }
    }
}
