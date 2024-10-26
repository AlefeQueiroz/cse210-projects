// EternalGoal.cs
using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {Points} points for '{Name}'!");
    }

    public override bool IsComplete()
    {
        return false; // Never complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{Points}";
    }
}
