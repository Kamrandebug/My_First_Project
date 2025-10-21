using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_5.RefFunctions
{
    internal class RefSyntax
    {
        // 🧠 Function jo name change karega using ref (reference parameter)
        static void ChangeName(ref string name, string newName)
        {
            // ✨ 'ref' ke wajah se ye 'name' main wale variable ko directly modify karega
            name = newName;
        }

        public static void Run()
        {
            // 🧩 Step 1: Ek variable banao jisme pehla name store hai
            string name = "Ali";

            // 🧩 Step 2: User se naya name input lena
            Console.Write("Enter New Name : ");
            string newName = Console.ReadLine();

            // 🧩 Step 3: Function call karte waqt 'ref' likhna mandatory hai
            // Ye 'name' variable ka actual address bhejta hai
            // Function ke andar change directly original variable me reflect hoga
            ChangeName(ref name, newName);

            // 🧩 Step 4: Ab 'name' update ho chuka hoga
            // Function ne original value overwrite kar di
            Console.WriteLine($"Your name is {name}");
        }
    }
}

