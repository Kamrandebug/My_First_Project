using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.IF_Statements
{
    internal class Multiplication_Program
    {
        public static void Run()
        {
            Console.Write("Enter First Number : ");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);

            Console.Write("Enter Second Number : ");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            Console.WriteLine();

            double Actualanswer = num1 * num2;

            Console.Write("Multiplication of Number " + num1 + " And " + num2 + " is : ");
            string ans = Console.ReadLine();
            double answer = Convert.ToDouble(ans);

            Console.WriteLine();

            if (answer == Actualanswer)
            {
                Console.WriteLine("Your Answer is Correct Level H Bhai Ka 😎 ");
            }
            else
            {
                Console.WriteLine("Your Answer is Incorrect Bro ");
            }
        }
    }
}
