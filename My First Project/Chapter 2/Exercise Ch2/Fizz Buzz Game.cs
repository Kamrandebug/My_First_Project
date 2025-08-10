using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Exercise_Ch2
{
    internal class Fizz_Buzz_Game
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Fizz Buzz Game!");

            Console.WriteLine();

            Console.Write("Enter limit Untill You Want To Run This Game : ");

            bool limit = true;
            int result;

            while (limit)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine($"You Entered : {result}");
                }
                else
                {
                    Console.Write("Bhai ye number hai ya wifi ka password? Please enter a valid number : ");
                    continue;
                }


                for (int i = 1; i <= result; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Fizz Buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                }
                break;
            }

        }
    }
}

