using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная__4._1
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "b":
                    result = num1 - num2;
                    break;
                case "c":
                    result = num1 * num2;
                    break;
                case "d":
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("your cute calculator");
            Console.WriteLine("------------------------\n");
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("type a number, and then press enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("this is not valid input; please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("type another number, and then press enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("this is not valid input; please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }
                Console.WriteLine("choose an operator from the following list:");
                Console.WriteLine("\ta - add");
                Console.WriteLine("\tb - subtract");
                Console.WriteLine("\tc - multiply");
                Console.WriteLine("\td - divide");
                Console.Write("Your option? ");


                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("this operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("oh no! an exception occurred trying to do the math.\n - details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.Write("press 'n' and enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}

