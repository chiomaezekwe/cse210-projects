using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Goal '{ShortName}' recorded! You earned {Points} points.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Bonus! You earned an additional {_bonus} points for completing the goal.");
            }
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return IsComplete() ? $"[X] Completed {_amountCompleted}/{_target} times" : $"[ ] {_amountCompleted}/{_target} times completed";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{ShortName},{Description},{Points},{_amountCompleted},{_target},{_bonus}";
    }
}
