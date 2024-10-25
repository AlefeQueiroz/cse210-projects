using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        // Initialize goals or menu logic here
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose Goal Type: 1. Simple 2. Eternal 3. Checklist");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter Checklist Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter goal index to record event: ");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            if (_goals[index].IsComplete())
            {
                _score += _goals[index] is ChecklistGoal ? ((ChecklistGoal)_goals[index]).GetStringRepresentation() : 0;
            }
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string[] goalData = parts[1].Split(",");

                if (goalType == "SimpleGoal")
                {
                    _goals.Add(new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
                }
                else if (goalType == "ChecklistGoal")
                {
                    _goals.Add(new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[3]), int.Parse(goalData[4])));
                }
            }
        }
    }
}
