using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Randomly select a scripture
        Scripture scripture = LoadRandomScripture();

        // Loop until all words are hidden or user quits
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText()); // Show scripture
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break; // Exit if user types "quit"
            }

            scripture.HideRandomWords(3); // Hide random words
        }

        Console.WriteLine("\nAll words are hidden. Program ending.");
    }

    public static Scripture LoadRandomScripture()
    {
        // Store a list of scriptures (could be loaded from a file for more creativity)
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want.")
        };

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        return scriptures[randomIndex]; // Return a random scripture
    }
}
