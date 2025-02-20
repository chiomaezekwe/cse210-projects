using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{ShortName}' recorded! You earned {Points} points.");
    }

    public override bool IsComplete() => false;         

    public override string GetDetailsString() => "[ ] Not Completed";  

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{ShortName},{Description},{Points}";
    }
}