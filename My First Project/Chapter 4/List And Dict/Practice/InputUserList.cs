using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.List_And_Dict.Practice
{
    internal class InputUserList
    {
        public static void Run()
        {
            Console.Write("How Many Values To Store In List : ");

            int values = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            for(int i = 0; i < values; i++)
            {
                 Console.WriteLine($"Enter Value {i+1}");
                 int num  = Convert.ToInt32(Console.ReadLine());
                 numbers.Add(num);
            }

            foreach(int n in numbers)
            {
                Console.WriteLine($"List Member : {n}");
            }
        }
    }
}
