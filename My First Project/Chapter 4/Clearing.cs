using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4
{
    internal class Clearing
    {
        public static void Run()
        {
            int[] numbers = new int[]
            {
                9,4,5,7,34,23,4,6
            };
            Array.Clear(numbers,3,2);
            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
