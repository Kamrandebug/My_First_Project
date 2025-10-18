using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.ArraysOnly
{
    internal class ArrayOfMultiple
    {
        public static void Run()
        {
            /*

                Define and initialize two integers (num, length)

                Example: (7, 5) → [7, 14, 21, 28, 35]

                Create an integer array with size = length

                Loop through and store (loop index + 1) × num into the array

                Print the final array
            */

            int num = 7;
            int length = 5;

            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = (i + 1) * num;
            }

            foreach (int value in result)
            {
                Console.Write(value + " ");
            }

        }
    }
}
