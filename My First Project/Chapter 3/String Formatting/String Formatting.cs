using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3
{
    internal class String_Formatting
    {
        public static void Run()
        {
            /*
             
            Composite Formatting in C# :
            
            Composite formatting lets you place placeholders ({0}, {1}, {2}, etc.) inside a string,
            and then replace them with values provided after the string.

            {0} means first value after the string

            {1} means second value after the string

            {2} means third value, and so on…

            */

            string name = "Kamran";
            int age = 20;
            string city = "Lahore";

            Console.WriteLine("Your Name is : {0} \nYour Age is : {1} \nYour City is : {2}" , name , age , city);

        }
    }
}
