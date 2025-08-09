using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2
{
    internal class Calculator_Using_IF
    {
        public static void Run()
        {
            Console.Write("Enter Number 1 : ");
            string input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);

            Console.WriteLine();

            Console.Write("Enter Number 2 : ");
            string input2 = Console.ReadLine();
            double num2 = Convert.ToDouble(input2);

            Console.WriteLine();

            Console.WriteLine("Enter Operator +,-,*,/,%");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine("Addition is : " + (num1 + num2));
            }
            else if (op == "-")
            {
                Console.WriteLine("Subtraction is : " + (num1 - num2));
            }
            else if (op == "*")
            {
                Console.WriteLine("Multiplication is " + (num1 * num2));
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error Cant divide to 0 !");
                }
                else
                {
                    Console.WriteLine("Division is : " + (num1 / num2));
                }
            }
            else if (op == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error Cant Take 0 For Modulus !");
                }
                else
                {
                    Console.WriteLine("Modulus or Remainder is : " + (num1 % num2));
                }
            }
            else
            {
                Console.WriteLine("Wrong Opeartor !!!!!");
            }

        }
    }
}
