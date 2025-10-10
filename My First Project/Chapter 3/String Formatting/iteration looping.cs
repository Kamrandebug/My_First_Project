using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace My_First_Project.Chapter_3.String_Formatting
{
    internal class iteration_looping
    {
        public static void Run()
        {
            // Iteration Looping in C#

            /* Basically, this is just looping through 
             * each letter of a string one by one, 
             * like reading a TikTok comment section word by word 😏.*/


            /*
             💡 message.Length → tells how many characters are in the string.
             💡 message[i] → gets the character at position i (index starts from 0).
            */
            string message = "C# is Amazing!";

            // Loop through each character in the string
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);         // Print each character without a new line
                Thread.Sleep(50);                  // Small delay so the text appears slowly
            }

            Console.WriteLine();                   

            // Check if the string contains the letter 'z' using the built-in Contains method
            
            Console.WriteLine(message.Contains('z'));

            bool contain = false;                  // Variable to track if 'z' is found

            // Loop through the string again to manually check for 'z'

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('z'))        // If the current character is 'z'
                {
                    contain = true;                // Mark contain as true
                }
            }

        }
    }
}
