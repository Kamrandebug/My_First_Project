using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3.Practice
{
    internal class Word_Reverser
    {
        public static void Run()
        {
            // Ask user to enter a string
            Console.Write("Enter String To Reverse : ");
            string input = Console.ReadLine();
            Console.WriteLine();

            // Loop will start from the last character (input.Length - 1) 
            // and go till the first character (index 0)
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // Print each character in reverse order (right → left)
                Console.Write($"{input[i]}");
            }

            // Move to next line after printing reversed string
            Console.WriteLine();


        }
    }
}
