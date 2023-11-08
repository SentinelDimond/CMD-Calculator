using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            string answer;
            double result = 0;
            bool nonValidOperation = true;
            while (true)
            {
                Console.WriteLine("Welcome to Dimond's CMD calculator app\n");
                Console.Write("Input your first number: ");
                  
               while (true) 
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out num1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error, Input a number.");
                    }
                    
                }
                Console.WriteLine("Your first number is " + num1 + ".\n");

                Console.Write("Input your second number:");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out num2))
                    {
                        break;
                    }
                    else 
                    { 
                     Console.WriteLine("Error, Input a number."); 
                    }
                }
                
                Console.WriteLine("Your second number is " + num2 + ".\n");
                Console.WriteLine("How would you like to use these numbers? Press\n'A' for addition\n'S' for subtraction\n'M' for multiplication\n'D' for divison.");
                
                
                while (nonValidOperation == true)
                {
                    nonValidOperation = true;
                    answer = Console.ReadLine().ToLower();

                    switch (answer)
                    {
                        case "a":
                            result = num1 + num2;
                            Console.WriteLine($"Your result is: {result}");
                            nonValidOperation = false;
                            break;

                        case "s":
                            result = num1 - num2;
                            Console.WriteLine($"Your result is: {result}");
                            nonValidOperation = false;
                            break;

                        case "m":
                            result = num1 * num2;
                            Console.WriteLine($"Your result is: {result}");
                            nonValidOperation = false;
                            break;

                        case "d":
                            result = num1 / num2;
                            double remainder = num1 % num2;
                            Console.WriteLine($"Your result is: {result}, with a remainder of: {remainder}");
                            nonValidOperation = false;
                            break;

                        default:
                            Console.WriteLine("Invalid selection. choose 'A', 'S' 'M' or 'D'");
                            break;
                           
                    }
                    
                }
                

                Console.WriteLine("You are done using the calculator. Press 'R' then 'Enter' to restart. or press any other button then 'Enter' to close the app");
                string restart = Console.ReadLine().ToLower();
                Console.Clear();
                if ( restart != "r" ) 
                {
                    break;
                }
                
            }
           
        }
    }
}
