using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4
{
    internal class JustSyntax
    {
        public static void Run()
        {

            //  "C# Program – Input & Display using Integer Array"

            //    int[] numbers = new int[5];
            /*
                Console.Write("Enter Number : ");
                numbers[0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number : ");
                numbers[1] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number : ");
                numbers[2] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number : ");
                numbers[3] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number : ");
                numbers[4] = Convert.ToInt32(Console.ReadLine());
            */


          //  using loops only

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter Number : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
