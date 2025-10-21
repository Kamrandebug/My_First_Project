using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5.Exercise
{
    internal class SumOfArray
    {
        static int SumOfNumber(int[] numbers)
        {
            // Check if array has any elements
            if (numbers.Length > 0)
            {
                int total = 0;

                // Loop through each number and add to total
                foreach (int n in numbers)
                {
                    total += n;
                }
                return total;
            }
            // Return -1 if array is empty 
            return -1;
        }

        public static void Run()
        {
            int[] numbers = new int[]
            {
                1, 23, 45, 5, 69
            };

            // Call the function and print the total sum
            Console.WriteLine($"Total Sum is : {SumOfNumber(numbers)}");
        }

    }
}
