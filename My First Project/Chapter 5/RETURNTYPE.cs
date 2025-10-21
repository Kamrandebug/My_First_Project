using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5
{
    internal class RETURNTYPE
    {
        public static void Run()
        {
            string msg = Welcome();
            Console.WriteLine(msg);
        }

        static string Welcome()
        {
            return "Welcome to C# Functions";
        }

        /*
         
         Rule of Return Functions:

        ✔ Must have a return type (int, string, bool, etc.)
        ✔ Must use return keyword
        ✔ Must return matching type
        
         */
    }
}
