using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Table_of_N
    {
        public static void Run()
        {
            Console.Write("Enter value of N : ");
            int n = Convert.ToInt32(Console.ReadLine());


            int total;


            for (int i = 1; i <= 10; i++)
            {
                total = n * i;
                Console.WriteLine(n + " X " + i + " = " + total);
            }
        }
    }
}
