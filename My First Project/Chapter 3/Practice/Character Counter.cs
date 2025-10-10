using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3.Practice
{
    internal class Character_Counter
    {
        public static void Run()
        {
            /* User se ek string input lo aur count karke batao ke
              usme kitne characters hain (spaces bhi count ho). */

            Console.Write("Enter a String to count all characters : ");
            string input = Console.ReadLine();

           // Console.WriteLine($"Total Characters in string are : {input.Length}");

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter++;
            }
            Console.WriteLine($"Total characters in the string:{counter}");
        }
    }
}
