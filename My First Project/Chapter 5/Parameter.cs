using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5
{
    internal class Parameter
    {
        public static void Run()
        {
            int sum = Add(10, 20);
            Console.WriteLine(sum);
        }

        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
