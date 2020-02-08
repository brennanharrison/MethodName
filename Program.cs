// Programmer: Brennan Harrison
// Date: 02/07/2020
// Assignment: Deliverable 3 - Methods

using System;
using System.Text.RegularExpressions; // Regular expression library.

namespace MethodName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their name.
            Console.WriteLine("Please enter your name!");

            // Store user input.
            string userName = Console.ReadLine();

            // Pass user input to method.
            outputName(userName);
        }


        // Custom method.
        static void outputName(string argument)
        {   
            // Pattern for user string to follow.
            string test = @"^(\s*[A-Za-z]+\s*)+$";

            // re variable holding pattern.
            Regex re = new Regex(test);

            // If user input does not contain any digits or special characters:
            if (re.IsMatch(argument))
            {
                // Write a string to the console with the user's input.
                Console.WriteLine("Hello " + argument+"!");
            }

            // Else execute:
            else
            {
                // Write a string stating the input is incorrect.
                Console.WriteLine("Wrong form of input!");
            }
        }
    }
}
