using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        // Declaring Variables
        static string username;
        static string userInput;
        static int userNum;
        static bool cont = true;

        static void Main(string[] args)
        {
            // Start with user's name
            UserName();
            do
            {
                // Run the methods in this order
                Console.WriteLine("Enter a number between 1 and 100:");
                ValidateInput();
                Conditions();
                Continue();
            }
            // End program if cont is false
            while (cont);
        }

        static void UserName()
        {
            // Get Username
            Console.WriteLine("Hello! What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hi {0}, let's get started!", username);
        }

        static void ValidateInput()
        {
            // Check if user input is an integer
            userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out int result))
            {
                Console.WriteLine("Invalid input. Try again:");
                userInput = Console.ReadLine();
            }
            // Apply input to the int userNum
            userNum = int.Parse(userInput);
            Console.WriteLine("");
        }

        static void Conditions()
        {
            // Check if input is between 1 and 100
            if (userNum <= 100 && userNum > 0)
            {
                // Check if odd or even
                if (userNum % 2 == 1)
                {
                    // The results for >60 and <60 are the same but the if statement is here anyways
                    if (userNum > 60)
                    {
                        Console.WriteLine("The number {0} is odd", userNum);
                    }
                    else
                    {
                        Console.WriteLine("The number {0} is odd", userNum);
                    }
                }
                else
                {
                    // Check if less than 25, or if greater than 60, or something in between
                    if (userNum < 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (userNum > 60)
                    {
                        Console.WriteLine("The number {0} is even", userNum);
                    }
                    else
                    {
                        Console.WriteLine("Even", userNum);
                    }
                }
            }
            else
            {
                // Error message if input was outside of the range
                Console.WriteLine("Your number isn't between 1 and 100!");
            }
        }

        static void Continue()
        {
            // Ask if user wants to continue
            Console.WriteLine("");
            Console.WriteLine("Thank you for playing {0}! Would you like to play again? (y/n)", username);

            // if not we change the bool cont to false, which will end the program
            if (Console.ReadLine() == "n")
            {
                cont = false;
            }
            Console.WriteLine("");
        }
    }
}
