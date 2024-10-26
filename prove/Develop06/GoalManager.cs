// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal: (1) Simple, (2) Eternal, (3) Checklist");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Enter the goal number to record progress: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            if (goal is SimpleGoal || goal.IsComplete())
            {
                _score += goal.Points;
            }
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
        }
        Console.WriteLine($"Total Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine($"Score:{_score}");
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string type = parts[0];

            if (type == "Score")
            {
                _score = int.Parse(parts[1]);
            }
            else
            {
                string[] data = parts[1].Split(",");
                Goal goal = null;
                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                        break;
                }
                _goals.Add(goal);
            }
        }
    }
}
