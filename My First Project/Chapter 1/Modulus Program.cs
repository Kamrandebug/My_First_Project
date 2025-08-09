using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_1
{
    internal class Modulus_Program
    {
        public static void Run()
        {
            string num1;
            Console.WriteLine("Enter num1 : ");
            num1 = Console.ReadLine();
            int Number = Convert.ToInt32(num1);

            string num2;
            Console.WriteLine("Enter num2 : ");
            num2 = Console.ReadLine();
            int Number2 = Convert.ToInt32(num2);

            Console.WriteLine("Modulus of Numbers are : " + (Number % Number2));
        }
    }
}
