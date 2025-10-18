using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.List_And_Dict.Practice
{
    internal class GradesDict
    {
        public static void Run()
        {
            Dictionary<string, string> students = new Dictionary<string, string>
            {
                {"Kamran","Grade A"},
                {"Ali","Grade C"},
                {"Saad","Grade A"},
            };

            Console.Write("Enter Student Name To Check Grade : ");
            string inputname = Console.ReadLine();

            if (students.TryGetValue(inputname, out string name))
            {
                Console.WriteLine();
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Not Found!!!");
            }

        }
    }
}
