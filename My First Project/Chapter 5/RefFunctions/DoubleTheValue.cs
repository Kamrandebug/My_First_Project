using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5.RefFunctions
{
    internal class DoubleTheValue
    {
        static void RefDouble(ref int num)
        {
            num = num + num;
        }
        public static void Run()
        {
            {
                Console.Write($"Enter Any Number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                RefDouble(ref num);
                Console.Write($"After doubling: {num}");
            }
        }
    }
}
