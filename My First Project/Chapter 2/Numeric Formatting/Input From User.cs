using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Numeric_Formatting
{
    internal class Input_From_User
    {
        public static void Run()
        {
            Console.Write("Enter a Number : ");
            double inputnumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("2 Decimal Formating : " + $"{inputnumber: 0.00}");

            Console.WriteLine("Currency Local : " + inputnumber.ToString("C"));
        }
    }
}
