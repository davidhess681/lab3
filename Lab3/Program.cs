using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {


        static void Main(string[] args)
        {
            // Declaring Variables
            string username;
            string userInput;
            int userNum;
            bool cont = true;

            // Get Username
            Console.WriteLine("Hello! What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hi {0}, let's get started!", username);

            do
            {
                Console.WriteLine("Enter a number between 1 and 100:");

                // Validate User Input
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out int result))
                {
                    Console.Write("Invalid input. Try again:");
                    userInput = Console.ReadLine();
                }
                userNum = int.Parse(userInput);
                Console.WriteLine("");

                // Conditions (if statements)
                if (userNum <= 100 && userNum > 0)
                {
                    if (userNum % 2 == 1)
                    {
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
                    Console.WriteLine("Your number isn't between 1 and 100!");
                }

                // Continue?
                Console.WriteLine("");
                Console.WriteLine("Thank you for playing {0}! Would you like to play again? (y/n)", username);
                if (Console.ReadLine() == "n")
                {
                    cont = false;
                }
                Console.WriteLine("");
            }
            while (cont);
        }

    }
}
