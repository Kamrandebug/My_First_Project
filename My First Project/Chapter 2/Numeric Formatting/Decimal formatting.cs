using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Numeric_Formatting
{
    internal class Decimal_formatting
    {
        public static void Run()
        {
            // Numeric Formatting in C#

            // Basic decimal formatting

            double number = 1234.5678;

            // Basic decimal formatting Using String Interpolation

            Console.WriteLine("Original Number: " + number);

            Console.WriteLine("No Decimal : " + $"{number:0}");
            Console.WriteLine("One Decinal : " + $"{number:0.0}");
            Console.WriteLine("Two Decinals : " + $"{number:0.00}");
            Console.WriteLine("Three Decinals : " + $"{number:0.000}");
        }
    }
}
