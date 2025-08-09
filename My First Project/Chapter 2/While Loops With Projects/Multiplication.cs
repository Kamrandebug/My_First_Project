using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.While_Loops_With_Projects
{
    internal class Multiplication
    {
        public static void Run()
        {
            Console.Write("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int ActualAnswer = num1 * num2;
            int answer = 0;
            Console.WriteLine();

            Console.WriteLine("What will the answer of " + num1 + " X " + num2 + " ? ");

            Console.WriteLine();


            while (answer != ActualAnswer)
            {
                Console.Write("Enter Your Answer : ");
                answer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();


                if (answer != ActualAnswer)
                {
                    Console.WriteLine("Close But Answer is Wrong....!!!!!!");
                }

                Console.WriteLine();

            }

            Console.WriteLine("Well Done Correct Answer .......");

        }
    }
}
