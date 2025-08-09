using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.For_Loops
{
    internal class Using_For_Loop__Multiplication
    {
        public static void Run()
        {
            // Using For Loop Multiplication Program
            
             double number1 = 2D;
                        double number2 = 8D;

                        double answer = number1 * number2;

                        int attempt = 0;

                        Console.Write("What Would Be The Answer Of " + number1 + " X " + number2 + " : " );
                        double inputAnswer = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine();



                        for( double i = inputAnswer; i != answer; i++ )
                        {
                            if(inputAnswer == answer)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Wrong Answer Enter Value Again : ");

                                inputAnswer = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();
                                attempt++;
                            }

                        }
                        Console.WriteLine("Congratulations You Solve This Problem in : " + attempt + " Attempts " );
        }
    }
}
