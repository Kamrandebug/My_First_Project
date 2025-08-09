using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.While_Loops_With_Projects.Do_While
{
    internal class Password_System
    {
        public static void Run()
        {
            // Do While Loops in C#

            double password = 1234;
            double inputPassword;

            do
            {
                Console.Write("Enter Password : ");
                inputPassword = Convert.ToDouble(Console.ReadLine());
            } while (inputPassword != password);

            Console.WriteLine("Access Granted Right Password");


            Console.ReadLine();
        }

    }
}
