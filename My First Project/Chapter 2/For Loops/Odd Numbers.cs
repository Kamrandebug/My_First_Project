using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Odd_Numbers
    {
        public static void Run()
        {
            Console.WriteLine("Odd Numbers from 1 to 100:");

            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(); // For better readability
        }
    }
}
