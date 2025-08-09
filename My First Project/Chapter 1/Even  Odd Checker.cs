using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_1
{
    internal class Even___Odd_Checker
    {
      public  static void Run()
        {
            int num1 = 10;
            int num2 = 3;

            double output = num1 % num2;
            Console.WriteLine(output);

            num1 = 11;
            output = num1 % num2;
            Console.WriteLine(output);
        }
    }
}
