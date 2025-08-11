using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_3
{
    internal class Escape_Characters
    {
        public static void Run()
        {
            /*
             * Common Escape Characters & Uses:

                \n → New line (text next line me chala jaye)

                \t → Tab space (extra gap dena)

                \\ → Backslash print karna

                \" → Double quotes ke andar double quotes print karna

                \' → Single quotes ke andar single quotes print karna

             * */


            Console.WriteLine("Hello\nWorld");   // Hello 
                                                 // World

            Console.WriteLine("Name:\tCodeX");   // Name:    CodeX

            Console.WriteLine("This is a backslash: \\"); // This is a backslash: \

            Console.WriteLine("He said, \"C# is cool!\""); // He said, "C# is cool!"

        }
    }
}
