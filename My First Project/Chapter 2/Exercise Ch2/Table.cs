using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Exercise_Ch2
{
    internal class Table
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Table Program!");
            Console.WriteLine("This program will display a multiplication table for a number you choose.");
            Console.Write("Please enter a number: ");
            
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i =1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}" , number , i , i*number );
            }
        }
    }
}
