using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.List_And_Dict.Practice
{
    internal class LoginSystemDict
    {
        public static void Run()
        {
            Dictionary<string, string> login = new Dictionary<string, string>
            {
                {"kamran","123"},
                {"admin","pass1"}
            };

            bool inputuser = true;
            string username = "";

            while (inputuser)
            {
                Console.Write("Enter Username : ");
                username = Console.ReadLine();

                if (login.ContainsKey(username))
                {
                    inputuser = false;
                } else
                {
                    Console.WriteLine("Wrong Username Enter Again");
                }
            }

                Console.WriteLine();

            bool inputpass = true;

            while(inputpass)
            {
                Console.Write("Enter password : ");
                string password = Console.ReadLine();

                if (password == login[username])
                {
                    inputpass = false;
                } else
                {
                    Console.WriteLine("Wrong Password Enter Again");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Access Granted Welcome");

            

        }
    }
}
