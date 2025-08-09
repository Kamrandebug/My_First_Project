using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Main_For_Loop
    {
        public static void Run()
        {
            Console.Write("Enter message or value you want to repeat :  ");
            string repeat = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter Amount of Iteration : ");
            int counter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(repeat);
            }
        }
    }
}
