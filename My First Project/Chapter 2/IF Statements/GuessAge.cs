using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.IF_Statements
{
    internal class GuessAge
    {
        public static void Run()
        {
            /*
             * Asks the user to guess your ageGives different responses
             * based on their guessUses if-else statements to make decisions
            */


            Console.WriteLine("Guess My Age ! ");
            string inputAge = Console.ReadLine();
            int age = Convert.ToInt32(inputAge);

            if(age <= 10)
            {
                Console.WriteLine("I am Older Than 10");
            }
            else if(age >= 10 && age < 20)
            {
                Console.WriteLine("Yeah I am Between 10 to 20 Years Old");            
            }
            else if (age >=20 && age < 30)
            {
                Console.WriteLine("I am Younger ");
            }
            else if (age >= 30)
            {
                 Console.WriteLine("You Enterd Too big Number i am Younger Bro");
            }


         }
    }
}
