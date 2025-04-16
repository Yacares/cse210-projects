public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
         if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You have completed the Checklist Goal '{GetShortName()}' {_amountCompleted}/{_target} times.");

            if (_amountCompleted == _target)
            {
                // When completed, you get the bonus
                Console.WriteLine($"You completed the goal! You will earn an additional {GetBonus()} points.");
            }
        }
        else
        {
            Console.WriteLine($"The Checklist Goal '{GetShortName()}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return GetAmountCompleted() >= GetTarget();
    }

    public override string GetDetailsString()
    {
        return $"Goal Type: Checklist Goal\nName: {GetShortName()}\nDescription: {GetDescription()}\n" +
               $"Completion Status: {(IsComplete() ? "Completed" : "Not Completed")}\nPoints: {GetPoints()}\n" +
               $"Progress: {_amountCompleted}/{_target} completed\nBonus Points for Completion: {_bonus}\n";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_target},{_amountCompleted},{_bonus}";
    }
}