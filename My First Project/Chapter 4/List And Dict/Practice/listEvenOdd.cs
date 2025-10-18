using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.List_And_Dict.Practice
{
    internal class listEvenOdd
    {
        public static void Run()
        {
            /*
             * Create two lists with integer data type, one for even numbers and one for odd
             * Loop from 0 to 20
             *     If number is even, add to even list
             *     If number is odd, add to odd list
             * Print even list
             * Print odd list
             */

            List<int> even = new List<int>();

            List<int> odd = new List<int>();

            for(int i = 0; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    even.Add(i);
                } else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Even Numbers");

            foreach(var number in even)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();

            Console.WriteLine("Odd Numbers");

            foreach (var number in odd)
            {
                Console.Write($"{number} ");
            }

        }
    }
}
