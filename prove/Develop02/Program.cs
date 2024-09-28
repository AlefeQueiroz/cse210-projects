using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");
        
        while (running)
        {
            // Display menu options
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            // Get user input
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Write
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2": // Display
                    journal.DisplayAll();
                    break;
                case "3": // Load
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully.");
                    break;
                case "4": // Save
                    Console.Write("Enter the filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully.");
                    break;
                case "5": // Quit
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to handle writing a new entry
    private static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("Write your entry: ");
        string entryText = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");

        // Create a new entry and add it to the journal
        Entry newEntry = new Entry(date, prompt, entryText);
        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added successfully.\n");
    }
}
