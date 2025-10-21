using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5.Exercise
{
    internal class AreaTriangle
    {
        static void Area(double width,double height)
        {
            double area = width * height / 2;
            Console.WriteLine($"Area is : {area}");
        }
        public static void Run()
        {
            Console.Write("Enter Width : ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter Height : ");
            double height = Convert.ToDouble(Console.ReadLine());

            Area(width, height);
        }
    }
}
