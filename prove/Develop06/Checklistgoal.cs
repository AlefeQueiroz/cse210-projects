// ChecklistGoal.cs
using System;

class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points) 
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress on '{Name}': {_amountCompleted}/{_target}");
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"You completed the checklist! Bonus: {_bonus} points.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{_target},{_amountCompleted},{_bonus}";
    }
}
