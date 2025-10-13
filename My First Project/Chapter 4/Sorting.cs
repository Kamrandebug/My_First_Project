using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4
{
    internal class Sorting
    {
        public static void Run()
        {
            int[] numbers = new int[]
            {
                93,43,5,2,1,55,6,7
            };

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

        }
    }
}
