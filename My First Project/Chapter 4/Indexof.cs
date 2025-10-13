using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4
{
    internal class Indexof
    {
        public static void Run()
        {
            /*
            int[] numbers = new int[]
             {
                 23,45,7,4,77,5,3
             };

            Console.Write("Enter Number To Search : ");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers,search);

            if(search > -1)
            {
                Console.Write($"Value {search} is Found At Position {position} ");
            }
            else
            {
                Console.Write("Value Not Found !!");
            }
            */


            // Behavior with Duplicate Values

            /*       int[] numbers = { 10, 20, 30, 30, 40 };
                     int index = Array.IndexOf(numbers, 30); // Returns 2 (First 30 only)

                     int position = Array.IndexOf(numbers, 30);

                     Console.Write($"Value is Found At Position {position} ");
             */

            // Search Within Specific Range

            int[] numbers = { 10, 20, 45, 30, 40 };
            int index = Array.IndexOf(numbers, 30, 1, 3);

            // Parameters:
            // numbers → Your array
            // 30      → Value to find
            // 1       → Start index (search will begin from index 1)
            // 3       → Range/Count (total elements to search from start index, till 1+3)
        }
    }
}
