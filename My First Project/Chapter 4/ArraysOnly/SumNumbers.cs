using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace My_First_Project.Chapter_4.ArrayBasicPractice
{
    internal class SumNumbers
    {
        public static void Run()
        {
            int[] numbers = new int[5];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter Number {i} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*
            “We initialize sum = 0 because local variables in C# don’t have a default value.
            Without initialization, we cannot safely perform addition.”
            */

          //  num → Array ka ek single element

            int sum = 0;

            foreach(int num in numbers)
            {
                sum += num; 
            }
            Console.WriteLine($"Sum Of Numbers is : {sum}");
        }
    }
}
