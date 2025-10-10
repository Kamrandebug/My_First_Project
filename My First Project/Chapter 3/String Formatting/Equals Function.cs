using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3.String_Formatting
{
    internal class Equals_Function
    {
        public static void Run()
        {
            /*Equals() is a method used to compare two values (or objects)
             * To see if they are equal in content,
             * Not just if they point to the same memory location.*/

            string value1 = "Codex";
            string value2 = "Codex";

            if(value1.Equals(value2))
            {
                Console.WriteLine("Same Values");
            }
            else
            {
                Console.WriteLine("Different Values");
            }
        }
    }
}
