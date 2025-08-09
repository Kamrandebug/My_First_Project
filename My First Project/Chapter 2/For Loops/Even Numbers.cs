using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Even_Numbers
    {
        public static void Run()
        {

            for (int i = 2; i <= 50; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
