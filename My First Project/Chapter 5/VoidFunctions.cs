using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5
{
    internal class VoidFunctions
    {
        public static void Run()
        {
            Hello();
            PrintArray();
        }

        static void Hello()
        {
            Console.WriteLine("Hello World");
        }

        static void PrintArray()
        {
            int[] numbers = new int[3]
            {
                10,20,30
            };

            foreach(var item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /*
            Void Function:

            Does NOT return a value

            Only performs an action (like printing, updating, etc.)

            Used when you just want to do something, not calculate something
        */

    }
}
