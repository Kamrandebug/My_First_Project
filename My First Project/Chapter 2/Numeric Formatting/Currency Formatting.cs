using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Numeric_Formatting
{
    internal class Currency_Formatting
    {
        public static void Run()
        {
            double number = 1234.5678;

            // Currency formatting

            Console.WriteLine("Currency Local : " + number.ToString("C"));
            Console.WriteLine("Currency US : " + number.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Currency UK : " + number.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine("Currency Australia : " + number.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
        }
    }
}
