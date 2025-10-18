using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4
{
    internal class Reversing
    {
        public static void Run()
        {
            int[] numbers = new int[]
             {
                1,2,3,4,5,6,7,8,9,10
             };
            Array.Reverse(numbers);
            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
