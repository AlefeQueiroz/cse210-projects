using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int squaredNumber = SquareNumber();
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber()
    {
        int number = PromptUserNumber();
        return number * number;
    }
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your favorite number is {squaredNumber}.");
    }
}
