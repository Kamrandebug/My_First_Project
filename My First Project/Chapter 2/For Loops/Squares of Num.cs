using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Squares_of_Num
    {
        public static void Run()
        {
            int total;

            for (int i = 1; i <= 10; i++)
            {
                total = i * i;
                Console.WriteLine(i + " X " + i + " = " + total);
            }
        }
    }
}
