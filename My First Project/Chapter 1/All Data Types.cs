using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_1
{
    internal class All_Data_Types
    {
        public static void Run()
        {
            // Numeric Data Types in C#
            int age = 20;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long number = 90000000000L;
            Console.WriteLine(number);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            float f = 2.0000f;
            Console.WriteLine(f);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            double d = 90000.89779;
            Console.WriteLine(d);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            decimal D = 9000.000m;
            Console.WriteLine(D);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Text Based Data Types in C#

            String S = "Kamran";
            char K = 'K';

            Console.WriteLine("My name is : " + S);
            Console.WriteLine(K);


            //  Converting String to Numeric Data Types
/*
            string textAge = "20";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textNumber = "90000000000";
            long number = Convert.ToInt64(textNumber);
            Console.WriteLine(number);

            string textFloat = "2.000000";
            float f = Convert.ToSingle(textFloat);
            Console.WriteLine(f);

            string textDouble = "90000.89779";
            double d = Convert.ToDouble(textDouble);
            Console.WriteLine(d);

            string textDecimal = "9000.89898";
            decimal k = Convert.ToDecimal(textDecimal);
            Console.WriteLine(k);
*/

            // Bool DataType

            bool a1 = true;
            bool b2 = false;

            Console.WriteLine(a1);
            Console.WriteLine(b2);
                

        }
    }
}
