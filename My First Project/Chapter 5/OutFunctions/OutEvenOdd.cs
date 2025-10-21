using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5
{
    internal class OutEvenOdd
    {
        static void checknumber(int num,out string status)
        {
            if(num % 2 == 0)
            {
                status = "Even";
            } else
            {
                status = "Odd";
            }

        }
        public static void Run()
        {
            string number;
            checknumber(1,out number);
            Console.WriteLine($"Number is : {number} ");
        }
    }
}
