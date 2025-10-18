using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace My_First_Project.Chapter_4.List_And_Dict
{
    internal class listSyntax
    {
        public static void Run()
        {
            List<int> listnumbers = new List<int>();

            listnumbers.Add(10);
            listnumbers.Add(20);
            listnumbers.Add(30);

            // listnumbers.Clear();

            //  listnumbers.RemoveAt(0);

            int total = listnumbers.Count();
            Console.WriteLine(total);

                foreach (int num in listnumbers)
                {
                    Console.WriteLine(num);
                }

            if (listnumbers.Contains(30))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
