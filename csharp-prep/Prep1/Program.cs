using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whats your first name? ");
        string fname = Console.ReadLine();
        Console.Write("Whats your last name? ");
        string lname = Console.ReadLine();
        Console.Write($"your name is: {lname}, {fname} {lname}.");
    }
}