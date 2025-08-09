using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2
{
    internal class GreetClock_Using_if
    {
        public static void Run()
        {
            Console.WriteLine("Enter Time Hour 0 to 23");
            string inputHour = Console.ReadLine();
            int time = Convert.ToInt32(inputHour);

            if (time >= 0 && time <= 11)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time >= 12 && time <= 17)
            {
                Console.WriteLine("Good AfterNoon!");
            }
            else if (time >= 18 && time <= 23)
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}
