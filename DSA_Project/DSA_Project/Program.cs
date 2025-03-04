using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace DSA_Project
{
    
    class Program
    {
        

        static void Main()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "                                            Welcome to Academic performance Evaluater    ");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            int e = 1;
            LinkedLIstcs Student = new LinkedLIstcs();
            Exceptional_handling exp = new Exceptional_handling();


            Student.GetStudentDetails();
            e = 1;



           
                Console.WriteLine("a->Bubblesort");
            Console.WriteLine("b->InsertionSort");
            Console.WriteLine("c->SelectionSort");
            Console.WriteLine("d-> Add more details");
            
            Console.Write("Enter your choice: ");
            char choice1 = Convert.ToChar(Console.ReadLine());
            switch (choice1)
            {
                case 'a':
                    Stopwatch sw = Stopwatch.StartNew();
                    Student.bubbleSort();
                    sw.Stop();
                    Console.WriteLine($"Time Taken {sw.ElapsedMilliseconds} ms");
                    break;

                case 'b':
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    Student.InsertionSort();
                    stopwatch.Stop();
                    Console.WriteLine($"Time Taken {stopwatch.ElapsedMilliseconds} ms");
                    break;

                case 'c':
                    Stopwatch stopwatch1 = Stopwatch.StartNew();
                    Student.selectionSort();
                    stopwatch1.Stop();
                    Console.WriteLine($"Time Taken {stopwatch1.ElapsedMilliseconds} ms");
                    break;

                case 'd':
                    Student.GetStudentDetails();
                    break;

                case 'e':
                    e = 0;
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    Console.ResetColor();
                    break;
            }
            while (e != 0)
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Choose which one you want?");
                Console.WriteLine("a->First Rank?");
                Console.WriteLine("b->Find student SGPA and Rank");
                Console.WriteLine("c->All students SGPA");
                Console.WriteLine("d-> Add more students' details ");
                Console.WriteLine("e->exit");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                char choice = Convert.ToChar(Console.ReadLine());

                switch (choice)
                {
                    case 'a':  
                        Student.FirstRank();
                        break;

                    case 'b':  
                        Console.Write("Enter the student Registration Number: ");
                        int Regnochoice = exp.GetValidInteger("Enter the student Registration Number: ");
                        Student.FindSGPAandRank(Regnochoice);
                        break;

                    case 'c':  
                        Student.DisplayAllStudents();
                        break;
                     
                     case 'd':
                        Student.GetStudentDetails();
                        break;
                   

                    case 'e':  
                        e = 0;
                        Console.WriteLine("Exiting the program...");
                        break;

                    default:  
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        Console.ResetColor();
                        break;
                }
            }


        }
    }
    
}
