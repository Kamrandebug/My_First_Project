using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_1
{
    internal class Var___Const
    {
        public static void Run()
        {
            //  var Keyword

            var name = "Kamran";
            var age = 20;
            var height = 99.99;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);


            // Const Keyword 
/*
            const string name = "KAMRAN";
            
            const int maxScore = 100;

            Console.WriteLine(name);
          
*/
            //maxScore = 200;        WE CANT CHANGE CONSTANT VALUE

        }
    }
}
