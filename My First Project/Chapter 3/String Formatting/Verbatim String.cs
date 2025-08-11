using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3
{
    internal class Verbatim_String
    {
        public static void Run()
        {
            string normal = "C:\\Users\\I.s computer\\Downloads";

            Console.WriteLine("Normal String: " + normal);

            // Verbatim String Example

            string verbatim = @"C:\Users\I.s computer\Downloads";

            Console.WriteLine("Verbatim String: " + verbatim);

            string multiline = @"This is ,
                                a multiline string,
                                which is very useful";

            Console.WriteLine("Multiline String: " + multiline);
        }
    }
}
