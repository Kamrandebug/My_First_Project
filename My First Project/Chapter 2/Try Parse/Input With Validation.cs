using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Try_Parse
{
    internal class Input_With_Validation
    {
        public static void Run()
        {
            // Input From User and Numeric Formatting with Validation


            bool sucess = true;

            while (sucess)
            {
                Console.Write("Enter Any Number : ");
                string inputnumber = Console.ReadLine();


                if (double.TryParse(inputnumber, out double result))
                {
                    Console.Write($"Successfully Converted And output In 2 decimals : {result: 0.00}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Value Enter Again ");
                }
            }
        }
    }
}
