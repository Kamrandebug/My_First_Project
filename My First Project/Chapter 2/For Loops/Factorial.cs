using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Factorial
    {
        public static void Run()
        {
            Console.Write("Enter Non Negative Integer : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;


            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine();

            Console.WriteLine("Factorial of " + n + " is : " + factorial);
        }
    }
}
