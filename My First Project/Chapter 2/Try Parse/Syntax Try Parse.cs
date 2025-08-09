using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Try_Parse
{
    internal class Syntax_Try_Parse
    {
        public static void Run()
        {
            // User se input lena
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // TryParse integer banane ki koshish karega
            // Agar convert ho gaya toh 'true' return karega, warna 'false'
            if (int.TryParse(input, out int age))
            {
                // Yahan tab aayega jab conversion successful ho
                Console.WriteLine("You entered a valid age: " + age);
            }
            else
            {
                // Yahan tab aayega jab conversion fail ho
                Console.WriteLine("Invalid number entered!");
            }
        }
    }
}
