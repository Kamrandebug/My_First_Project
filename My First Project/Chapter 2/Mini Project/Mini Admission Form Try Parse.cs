using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Chapter_2.Mini_Project
{
    internal class Mini_Admission_Form_Try_Parse
    {
        public static void Run()
        {
            // Mini Admission Form with TryParse Method

            // TryParse Method in C#
            
                        Console.WriteLine("Welcome To Mini Admission Form");
                        Console.WriteLine();

                        int age = 0;

                        string inputage;

                        bool agesuccess = true;


                        while(agesuccess)
                        {
                            Console.Write("Enter Your Age Between 18 - 30 : ");
                            inputage = Console.ReadLine();

                            if (int.TryParse(inputage, out age) && age >= 18 && age <= 30)
                            {
                                Console.WriteLine("Your Age is Stored ");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Age Input. Please Enter a Valid Age.");
                            }
                        }

                        Console.WriteLine();

                        
                        double hieght = 0.0;

                        string inputheight;

                        bool hieghtsuccess = true;

                        while (hieghtsuccess)
                        {
                            Console.Write("Enter Your Height must be between 1.4 and 2.2 meters : ");
                            inputheight = Console.ReadLine();

                            if (double.TryParse(inputheight, out  hieght) && hieght >= 1.4 && hieght <= 2.2)
                            {
                                Console.WriteLine("Your Height is Stored in meters");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Enter a Valid Height");
                            }
                        }

                        Console.WriteLine();

                        
                        bool student = false;

                        string inputstudent;

                        bool studentsuccess = true;

                        while (studentsuccess)
                        {
                            Console.Write("Are you a student? (true/false) (Yes/No) : ");
                            inputstudent = Console.ReadLine();

                            if (bool.TryParse(inputstudent, out student))
                            {
                                Console.WriteLine("Your Student Status is Stored " );
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Enter a Valid Status");
                            }
                        }

                        Console.WriteLine();

                        Console.WriteLine("Admission Form Submitted Successfully!");

                        Console.WriteLine();

                        Console.WriteLine("Your Details:");

                        Console.WriteLine("-------------------");

                        Console.WriteLine($"Age: {age}");

                        Console.WriteLine($"hieght : {hieght}");

                        Console.WriteLine($"Student Status: {student}");


        }
    }
}
