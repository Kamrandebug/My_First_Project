using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Numeric_Formatting
{
    internal class DISCOUNT_CALCULATOR
    {
        public static void Run()
        {
            Console.Write("Enter Original Amount : ");
            double originalAmount = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine();

            double discountPercentage;

            do
            {
                Console.Write("Enter Discount Percentage (0-100)% : ");

                discountPercentage = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

            } while (discountPercentage < 0 || discountPercentage > 100);

            double finalPrice = originalAmount - (originalAmount * (discountPercentage / 100));

            Console.WriteLine();

            Console.WriteLine("Original Amount : " + originalAmount.ToString("C"));
            Console.WriteLine();

            Console.WriteLine("Discount : " + $"{discountPercentage: 0.00} %");


            Console.WriteLine();

            Console.WriteLine("Final Price : " + finalPrice.ToString("C"));
        }
    }
}
