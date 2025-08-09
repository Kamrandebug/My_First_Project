using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Switch_Statements
{
    internal class Week_Days
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number between 1 and 7 to get the corresponding day of the week:");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}
