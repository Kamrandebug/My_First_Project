using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5
{
    internal class Optional
    {
        static int Multiply(int a,int b = 30)
        {
            return a * b;
        }
        public static void Run()
        {
            int result = Multiply(10);
            Console.WriteLine(result);
        }

        /*
             Concept Covered Here:

            Function with a default parameter

            If you don’t pass the second value → it uses the default (30)

            If you pass both values → default is ignored
        */
    }
}
