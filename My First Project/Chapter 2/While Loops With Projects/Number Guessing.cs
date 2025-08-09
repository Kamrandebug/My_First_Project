using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.While_Loops
{
    internal class Number_Guessing
    {
        public static void Run()
        {
            int guess = 5;

            Console.WriteLine("Welcome to the Guessing Game!");

            Console.Write("Enter Number To Guess The Seceret Number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            int attempts = 1;

            while (input != guess)
            {
                Console.WriteLine();
                Console.Write("Incorrect Enter Number Again : ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == guess)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You guessed the secret number!");
                    break;
                }

                else if (input > guess)
                {
                    Console.WriteLine();
                    Console.WriteLine("Too High! Try Again.");
                }
                else if (input < guess)
                {
                    Console.WriteLine();
                    Console.WriteLine("Too Low! Try Again.");
                }
                attempts++;
            }

            Console.WriteLine();

            Console.WriteLine("You Guesses The Number in " + attempts + " Attempts");

            Console.WriteLine();

            Console.WriteLine("Thank you for playing the Guessing Game!");

        }

    }
}
