using System;
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
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                string numInput2 = "";

                Console.Write("type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("this is not valid input; please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }
            }
        }
    }
}
