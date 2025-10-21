using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5.OutFunctions
{
    internal class OutSyntax
    {
        static void Out(out int i)
        {
            i = 20;
            i += i;
        }
        public static void Run()
        {
            int i;
            Out(out i);
            Console.WriteLine($"Value of i is : {i}");
        }
    }
}
