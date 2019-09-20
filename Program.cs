/*
 * Author: Tyler Powell
 * Date: 09/19/2019
 * Comments: This C# Console Application uses methods and prints
 *           to the console certain messages.
 */

using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    // Asks the user what their name is
                    Console.WriteLine("What is your name");
                    // Calls the WriteName method
                    WriteName();
                    // Asks the user if they have a nickname and prompts them to enter 'yes' or 'no'
                    Console.WriteLine("Do you have a nickname that you would like to enter too?");
                    Console.WriteLine("Please type 'yes' or 'no'");
                    // Calls the WriteNickname method
                    WriteNickname();
            }
            catch
            {
                // If an error occurs because of user input, this catch statement will occur
                Console.WriteLine("Errors occurred. Please exit the program and try again...");
            }
        }
        // The WriteName method
        private static void WriteName()
        {
            // Assigns user input to a variable named 'name'
            string name = Console.ReadLine();
            // Outputs a message including the name
            Console.WriteLine("Hello {0} ", name);
        }
        // The WriteNickname method
        private static void WriteNickname()
        {
            // Assigns user input to a variable named 'input'
            string input = Console.ReadLine();
            /* 
             An IF ELSEIF ELSE statement that tests if the user entered in 'yes', 'no', or another value to the 
             question that involves if the user has a nickname.
             */
            // If the user says 'yes' to having a nickname...
            if (input == "yes")
            { 
                Console.WriteLine("What is your  nickname?");
                string nickname = Console.ReadLine();
                Console.WriteLine("Hello {0} ", nickname + ". Nice to meet you!");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            // If the user says 'no' to having a nickname...
            else if (input == "no")
            {
                Console.WriteLine("That's okay...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            // If the user enters in a value other than 'yes' or 'no' to having a nickname...
            else
            {
                Console.WriteLine("You did not type 'yes' or 'no' OR you did not use the correct capitalization/lowercase letters");
                Console.WriteLine("Press any key to exit the program and try again if something was entered incorrectly");
                Console.ReadKey(true);
            }
        }
    }
}