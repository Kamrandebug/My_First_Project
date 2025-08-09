using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Sum_of_N
    {
        public static void Run()
        {
            Console.Write("Enter Value of N : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of " + n + " Values are " + sum);
        }
    }
}
