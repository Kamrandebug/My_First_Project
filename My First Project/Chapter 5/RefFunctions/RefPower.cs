using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5.RefFunctions
{
    internal class RefPower
    {
        static void Power(ref double num,out double cube)
        {
            // Store the original number before changing it in temp
            double temp = num;
            num = num * num;
            cube = temp * temp * temp;
        }
        public static void Run()
        {
            double cube;
            Console.Write("Enter Number : ");
            double num = Convert.ToDouble(Console.ReadLine());

            // Passing 'num' as ref (will be modified inside function)
            // and 'cube' as out (will be assigned inside function)

            Power(ref num,out cube);

            Console.Write($"After Squaring : {num}");
            Console.WriteLine();
            Console.Write($"After Cube : {cube}");
        }
    }
}
