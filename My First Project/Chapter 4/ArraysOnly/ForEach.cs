using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4
{
    internal class ForEach
    {
        public static void Run()
        {
            /*
             ForEach Loop :
            “The foreach loop is used to go through each value in an array or collection, one by one, without using an index.”
            */

            int[] numbers = new int[3];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter Number : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }

        }
    }
}
