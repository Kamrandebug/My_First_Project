using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Switch_Statements
{
    internal class Calculator
    {
        public static void Run()

        {
            Console.WriteLine("Welcome to the Simple Calculator Using Switch Statments !");

            Console.WriteLine();

            Console.Write("Enter First Value : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter Second Value : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter Operator +,-,*,/ : ");
            string op = Console.ReadLine();

            Console.WriteLine();


            switch (op)
            {
                case "+":
                    Console.WriteLine("Sum of " + a + " and " + b + " is " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("Subtraction of " + a + " and " + b + " is " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("Multiplication of " + a + " and " + b + " is " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("Division of " + a + " and " + b + " is = " + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid Operator !!!");
                    break;
            }

        }

    }
}
