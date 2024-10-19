using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}. Hope you enjoyed it!");
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner running...");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);  // 1 second delay
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("Countdown starting...");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);  // 1 second delay
        }
        Console.WriteLine("Go!");
    }
}
