using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5
{
    internal class NamedFunctions
    {
        // Named Parameters:
        // Call function using parameter names.
        // Order doesn't matter, improves clarity.

        static void order(string item,int quantity,string drink)
        {
            Console.WriteLine($"Item: {item}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Drink: {drink}");
        }
        public static void Run()
        {
            order(quantity: 3,
                item:"Pizza",
               drink: "Cola");
        }

    }
}
