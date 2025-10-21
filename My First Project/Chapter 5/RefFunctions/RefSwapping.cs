using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5.RefFunctions
{
    internal class RefSwapping
    {
        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        public static void Run()
        {
            Console.Write("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Swap(ref num1, ref num2);

            Console.Write($"OutPut After Swapping Num 1 = {num1}");
            Console.WriteLine();
            Console.Write($"OutPut After Swapping Num 2 = {num2}");
        }
    }
}
