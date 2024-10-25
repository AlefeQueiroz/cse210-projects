using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        // Load goals from file (if any)
        manager.LoadGoals();

        while (!exit)
        {
            Console.WriteLine("\nWelcome to Eternal Quest!");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List All Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event (Mark Goal Progress)");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    // Display player's current score and goal progress
                    manager.DisplayPlayerInfo();
                    break;

                case "2":
                    // List all goals with their current completion status
                    Console.WriteLine("\nGoal List:");
                    manager.ListGoalDetails();
                    break;

                case "3":
                    // Create a new goal (Simple, Eternal, or Checklist)
                    manager.CreateGoal();
                    break;

                case "4":
                    // Record an event for a goal (progress)
                    manager.RecordEvent();
                    break;

                case "5":
                    // Save goals and progress to a file
                    manager.SaveGoals();
                    Console.WriteLine("Goals saved successfully!");
                    break;

                case "6":
                    // Load goals and progress from a file
                    manager.LoadGoals();
                    Console.WriteLine("Goals loaded successfully!");
                    break;

                case "7":
                    // Exit the program
                    Console.WriteLine("Exiting the program. Goodbye!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid number from the menu.");
                    break;
            }
        }
    }
}
