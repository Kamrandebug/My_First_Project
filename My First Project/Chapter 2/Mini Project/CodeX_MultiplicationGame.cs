using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    internal class CodeX_MultiplicationGame
    {
        public static void Run()
        {

            // Manual Math Quiz Game v1
            // Built using while loops and conditionals
            // By: CodeX 🔥


            double num1 = 2;
            double num2 = 3;
            double num3 = 4;
            double num4 = 5;
            double num5 = 6;
            double num6 = 7;
            double num7 = 8;
            double num8 = 9;
            double num9 = 10;
            double num10 = 11;

            double Ans1 = num1 * num2;
            double Ans2 = num3 * num4;
            double Ans3 = num5 * num6;
            double Ans4 = num7 * num8;
            double Ans5 = num9 * num10;


            int score = 0;

            // Question 1 

            Console.Write("What is " + num1 + " X " + num2 + " : ");
            double input1 = Convert.ToDouble(Console.ReadLine());

            while (input1 != Ans1)
            {
                Console.WriteLine();

                Console.WriteLine("Incorrect! Try Again.");

                Console.Write("What is " + num1 + " X " + num2 + " : ");

                input1 = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine();

            Console.WriteLine("Correct!");

            score++;

            Console.WriteLine();

            Console.WriteLine("Press Enter For Next Question");

            Console.ReadLine();

            Console.WriteLine();

            //   Question 2

            Console.Write("What is " + num3 + " X " + num4 + " : ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            while (input2 != Ans2)
            {
                Console.WriteLine();

                Console.WriteLine("Incorrect! Try Again.");

                Console.Write("What is " + num3 + " X " + num4 + " : ");

                input2 = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine();

            Console.WriteLine("Correct!");

            score++;

            Console.WriteLine();

            Console.WriteLine("Press Enter For Next Question");

            Console.ReadLine();

            Console.WriteLine();

            // Question 3

            Console.Write("What is " + num5 + " X " + num6 + " : ");
            double input3 = Convert.ToDouble(Console.ReadLine());

            while (input3 != Ans3)
            {

                Console.WriteLine();

                Console.WriteLine("Incorrect! Try Again.");

                Console.Write("What is " + num5 + " X " + num6 + " : ");

                input3 = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine();

            Console.WriteLine("Correct!");

            score++;

            Console.WriteLine();

            Console.WriteLine("Press Enter For Next Question");

            Console.ReadLine();

            // Question 4

            Console.WriteLine();

            Console.Write("What is " + num7 + " X " + num8 + " : ");
            double input4 = Convert.ToDouble(Console.ReadLine());

            while (input4 != Ans4)
            {
                Console.WriteLine();

                Console.WriteLine("Incorrect Try Again");

                Console.Write("What is " + num7 + " X " + num8 + " : ");

                input4 = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Correct!");

            score++;

            Console.WriteLine();

            Console.WriteLine("Press Enter For Next Question");

            Console.ReadLine();

            // Question 5

            Console.WriteLine();

            Console.Write("What is " + num9 + " X " + num10 + " : ");
            double input5 = Convert.ToDouble(Console.ReadLine());

            while (input5 != Ans5)
            {
                Console.WriteLine();

                Console.Write("Incorrect Try Again ! : ");

                input5 = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Correct!");

            score++;

            Console.WriteLine();

            Console.WriteLine("Congratulations Correct Answers");

            Console.WriteLine();

            Console.WriteLine("Your Score is : " + score);
        }
    }
}
