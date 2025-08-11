using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3
{
    internal class Empty_String
    {
        public static void Run()
        {
            /*Empty String: A string value that has no characters in it
            — basically "" or string.Empty.
            In Below example, I am  checking if the user’s input is not empty before printing it.
            If it’s empty, print "Name is Empty".*/

            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            if(name != string.Empty)
            {
                Console.WriteLine();
                Console.WriteLine($"Your Name is : {name}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Name is Empty");
            }
        }
    }
}
