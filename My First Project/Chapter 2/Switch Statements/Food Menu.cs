using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Switch_Statements
{
    internal class Food_Menu
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Food Menu Chooser!");
            Console.WriteLine();
            Console.Write("Enter Value Between 1 to 5 For Menue : ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("You Ordered Pizza ! ");
                    break;
                case 2:
                    Console.WriteLine("You Ordered Zinger Jumbo Burger ! ");
                    break;
                case 3:
                    Console.WriteLine("You Ordered Zinger Cheese Paratha Roll ! ");
                    break;
                case 4:
                    Console.WriteLine("You Ordered Special Nali Beef Biryani ! ");
                    break;
                case 5:
                    Console.WriteLine("You Ordered Chicken Karahi ! ");
                    break;
                default:
                    Console.WriteLine("Sorry : Not Available In Menue !!!");
                    break;
            }
        }
    }
    
}
