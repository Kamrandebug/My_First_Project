using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5
{
    internal class OutParameter
    {
        static void Calculate(int a, int b,out int total,out int Multiply)
        {
            total = a + b;
            Multiply = a * b;
        }

        public static void Run()
        {
            int Sum;
            int Product;
            Calculate(5,3,out Sum,out Product);
            Console.WriteLine($"Sum: {Sum}");
            Console.WriteLine($"Product: {Product}");
        }
    }
}
