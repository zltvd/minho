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
                case "b":
                    result = num1 - num2;
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
            Console.WriteLine("your cute calculator");
            Console.WriteLine("------------------------\n");

        }
    }
}
