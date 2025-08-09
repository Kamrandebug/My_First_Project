using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2
{
    internal class IfStatements
    {
        public static void Run()
        {
            Console.Write("Enter Your Age : ");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);

          //  Using And && , OR || Operators

                        if(age <= 17)
                        {
                            Console.WriteLine("You are Between 17 and 0");
                        }
                        else if (age >= 18 && age <=25)
                        {
                            Console.WriteLine("You are Between 18 and 25");
                        }
                        else if(age >= 26)
                        {
                            Console.WriteLine("You are 26 or Older");
                        }
            
        }
    }
}
