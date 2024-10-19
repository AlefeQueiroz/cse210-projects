using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "Reflect on meaningful prompts.", 5)
    {
        _prompts = new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Reflect on your happiest moment."
        };
        _questions = new List<string>
        {
            "Why was this moment meaningful to you?",
            "How did this experience shape you?"
        };
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("Take some time to reflect on these questions:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowCountDown(5);
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        DisplayQuestions();
        DisplayEndingMessage();
    }
}
