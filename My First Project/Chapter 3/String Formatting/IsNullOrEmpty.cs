using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3.String_Formatting
{
    internal class IsNullOrEmpty
    {
        public static void Run()
        {

            /* 
              It checks two things at once:

                Null → The string doesn’t exist (has no value at all).

                Empty → The string exists but has nothing inside ("").
            */

            string a = null;
            string b = "";
            string c = "CodeX";

            Console.WriteLine(string.IsNullOrEmpty(a)); // true  (null)
            Console.WriteLine(string.IsNullOrEmpty(b)); // true  (empty)
            Console.WriteLine(string.IsNullOrEmpty(c)); // false  (has value)

            
        }

    }
}
