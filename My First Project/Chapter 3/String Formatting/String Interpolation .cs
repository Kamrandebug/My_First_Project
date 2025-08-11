using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3
{
    internal class String_Interpolation
    {
        public static void Run()
        {

            /*
             
            String Interpolation in C# :

            String interpolation is a feature in C# that lets you directly insert variables and expressions
            inside a string using a $ sign before the string.
            No {0}, {1} indexing — variables appear exactly where you write them. */
            
            string name = "Kamran";
            int age = 20;

            Console.WriteLine($"Your Name is {name} , And Your Age is {age}");

            Console.WriteLine();

            // You can also perform calculations directly within the string interpolation

            double price = 1234.5678;
            Console.WriteLine($"{price:0}");       // No decimals → 1235
            Console.WriteLine($"{price:0.00}");    // Two decimals → 1234.57
            Console.WriteLine($"{price:C}");       // Currency → $1,234.57



        }
    }
}
