using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_1
{
    internal class First_Calculator_Program
    {
        public static void Run()
        {
            string a;
            Console.WriteLine("Enter value of a");
            a = Console.ReadLine();
            int value1 = Convert.ToInt32(a);

            string b;
            Console.WriteLine("Enter vvalue of b");
            b = Console.ReadLine();
            int value2 = Convert.ToInt32(b);


            Console.WriteLine("Sum of NUmbers are :  " + (value1 + value2));
            Console.WriteLine("Subtraction of NUmbers are :  " + (value1 - value2));
            Console.WriteLine("Multiplication of NUmbers are :  " + (value1 * value2));
            Console.WriteLine("Division of NUmbers are :  " + (value1 / value2));
        }
    }
}
