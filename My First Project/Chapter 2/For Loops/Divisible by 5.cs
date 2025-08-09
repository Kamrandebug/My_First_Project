using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Divisible_by_5
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
