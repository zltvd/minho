﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная__4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("your cute calculator");
            while (!endApp)
            {
                double result = 0;
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
