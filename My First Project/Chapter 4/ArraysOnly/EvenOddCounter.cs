using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.ArrayBasicPractice
{
    internal class EvenOddCounter
    {
        public static void Run()
        {
            int[] numbers = new int[5];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter Number {i} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int Even = 0;
            int Odd = 0;

            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    Even++;
                }
                else
                {
                    Odd++;
                }
            }

            Console.WriteLine($"Total Even Numbers is : {Even}");
            Console.WriteLine($"Total Odd Numbers is : {Odd}");
        }
    }
}
