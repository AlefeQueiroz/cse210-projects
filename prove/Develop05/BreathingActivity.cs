using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "A mindfulness breathing exercise.", 5)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}
