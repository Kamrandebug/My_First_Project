using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3.Practice
{
    internal class PasswordChecker
    {
        public static void Run()
        {
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();

            Console.Write("Enter Password Again : ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if(password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Great Password Matches");
                        }
                        else
                        {
                            Console.WriteLine("Password Does Not Match");
                        }
                    } else
                    {
                        Console.WriteLine("Password Must Be At Least 6 Characters Long");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Plz Enter Password Confirmation");
                }
            }
            else
            {
                Console.Write("Plz Enter Password");
            }

        }
    }
}
