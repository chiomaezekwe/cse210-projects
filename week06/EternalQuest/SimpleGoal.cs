using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{ShortName}' completed! You earned {Points} points.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        return IsComplete() ? "[X] Completed" : "[ ] Not Completed";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{ShortName},{Description},{Points},{_isComplete}";
    }
}