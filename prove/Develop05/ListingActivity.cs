using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing Activity", "List as many things as you can within the time limit.", 5)
    {
        _prompts = new List<string>
        {
            "Things you're grateful for",
            "Things you like about yourself",
            "People who inspire you"
        };
        _count = 0;
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("You have 10 seconds to list as many things as you can!");
        ShowCountDown(3);
        Console.WriteLine(GetRandomPrompt());
        DateTime endTime = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < endTime)
        {
            Console.Write("Add to your list: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                userList.Add(item);
                _count++;
            }
        }
        return userList;
    }

    public void Run()
    {
        DisplayStartingMessage();
        List<string> userList = GetListFromUser();
        Console.WriteLine($"You listed {_count} items: {string.Join(", ", userList)}");
        DisplayEndingMessage();
    }
}
