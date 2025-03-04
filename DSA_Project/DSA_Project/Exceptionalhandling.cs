using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    public  class Exceptional_handling
    {
        public int GetValidInteger(string message)
        {
            int number;
            while (true) 
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                try
                {
                    number = Convert.ToInt32(input); 
                    break; 
                }
                catch (FormatException) 
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error:not a valid input.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                catch (OverflowException) 
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error:not a valid input.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

            return number;
        }
        public double GetValidDouble(string message) {
            double number;
            while (true) 
            {
                Console.Write(message);
                string input = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(input); 
                    break; 
                }
                catch (FormatException) 
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error:not a valid input.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                catch (OverflowException) 
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error:not a valid input.");
                    Console.ResetColor();
                    Console.WriteLine() ;
                }
            }

            return number;
        }

    }
}
