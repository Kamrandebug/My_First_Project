using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.While_Loops
{
    internal class Password_Lock_System
    {
        public static void Run()
        {
            string password = "codex123";

            Console.WriteLine("Welcome to the Password Protected System!");
            Console.WriteLine();

            Console.Write("Please Enter Your Password to Access the System: ");
            string input = Console.ReadLine(); ;

            while (input != password)
            {
                Console.WriteLine();

                Console.WriteLine("Access Denied ! Please Try Again.");

                Console.WriteLine();

                Console.Write("Enter Password Again : ");
                input = Console.ReadLine();

            }
            // When the user enters the correct password, the loop ends 
            Console.WriteLine();
            Console.WriteLine("Access Granted ! Welcome.");
        }
    }
}
