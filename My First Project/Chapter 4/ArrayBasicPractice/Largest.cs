using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.ArrayBasicPractice
{
    internal class Largest
    {
        public static void Run()
        {
            int[] number = new int[5];

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Enter Number {i}: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = number[0];
            foreach (int num in number)
            {
                if(num > max)
                {
                    max = num;
                }
            }

            Console.Write($"Largest Number is : {max}");

        }
    }
}
