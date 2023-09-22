using System;
using System.Collections.Generic;

namespace IterativePatternDemo1
{
    // The following code demonstrates an iterative design process for a basic text-based menu system.
    // Users can interact with the menu, provide feedback, and the menu can be refined iteratively based on that feedback.

    // Class to represent the menu
    class Menu
    {
        private List<string> options = new List<string>(); // List to store menu options

        // Method to add an option to the menu
        public void AddOption(string option)
        {
            options.Add(option);
        }

        // Method to display the menu
        public void Show()
        {
            Console.WriteLine("Menu:");
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }
        

        // Method to get the user's choice from the menu
        public int GetChoice()
        {
            while (true)
            {
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= options.Count)
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }

    class Program
    {
        // Main entry point of the program
        static void Main()
        {
            Menu menu = new Menu(); // Create an instance of the Menu class
            menu.AddOption("Option 1"); // Add menu options
            menu.AddOption("Option 2");
            menu.AddOption("Option 3");

            while (true) // Main loop for menu interaction and feedback
            {
                menu.Show(); // Display the menu
                Console.WriteLine("Please Choose Your Option..(1/2/3)");
                int choice = menu.GetChoice(); // Get the user's choice from the menu

                switch (choice) // Process the user's choice
                {
                    case 1:
                        Console.WriteLine("You selected Option 1.");
                        break;
                    case 2:
                        Console.WriteLine("You selected Option 2.");
                        break;
                    case 3:
                        Console.WriteLine("You selected Option 3.");
                        break;
                }

                // Ask for user feedback and determine whether to continue refining
                Console.Write("Was this menu easy to use? (yes/no): ");
                string feedback = Console.ReadLine().ToLower().Trim();
                if (feedback == "yes")
                {
                    Console.WriteLine("Thank you for your feedback! Exiting.");
                    break;
                }
                else
                {
                    Console.WriteLine("Taking user feedback into account, let's refine the menu.");
                    Console.WriteLine("\nRefining the menu...");
                }
            }
            Console.Read(); // Pause to keep the console window open
        }
    }
}