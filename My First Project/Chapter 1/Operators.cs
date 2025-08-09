using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_1
{
    internal class Operators
    {
        public static void Run()
        {
            // Operaots In C#

            int a = 10;
            int b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);

            int age = 20;
            Console.WriteLine(age >= 18);

            int x = 5;
            x += 3;


            Console.WriteLine(x);

            // Logical Operators in C#


            // And
/*
            int age = 20;
            bool isverified = true;

            bool canaccess = age >= 18 && isverified;

            Console.WriteLine(canaccess);
*/
            // OR

            int Age = 30;
            bool isVerifired = false;

            bool canAccess = Age > 20 || isVerifired;

            Console.WriteLine(canAccess);

            // NOT !

            bool isban = false;
            bool canLogin = !isban;

            Console.WriteLine(canLogin);


            // Modulus Operator  %

            int num1 = 10;
            int num2 = 3;

            Console.WriteLine("Modulus of Numbers are : " + (num1 % num2));

/*

            // Ternary Operator in C#

            // Ternary Operator is a shorthand for if-else statements

            // Syntax: condition ? value_if_true : value_if_false

            int age = -10;

            string result = age >= 0 ? "Valid Age" : "Invalid Age";
            Console.WriteLine(result);
*/


        }
    }
}
