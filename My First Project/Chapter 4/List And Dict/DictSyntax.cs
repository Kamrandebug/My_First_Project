using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_4.List_And_Dict
{
    internal class DictSyntax
    {
        public static void Run()
        {
            //  Syntax

            /*
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                {10,"Ali"},
                {20,"Kamran"},
                {30,"Saad"}
            };

            foreach(var n in students)
            {
                Console.WriteLine($"{n.Key} _ {n.Value}");
            }
            */

            Dictionary<string, string> Teachers = new Dictionary<string, string>
            {
                {"Math","Test1"},
                {"English","Test2"}
            };

            if(Teachers.TryGetValue("Math",out string Teacher))
            {
                Console.WriteLine("Teacher Found");
                Console.WriteLine(Teacher);
            }
            else
            { 
                Console.WriteLine("Teacher Not Found");
            }

            foreach (var T in Teachers)
            {
                Console.WriteLine($"{T.Key} _ {T.Value}");
            }

        }
    }
}
