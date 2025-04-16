public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"The Simple Goal '{GetShortName()}' is now completed!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"Goal Type: Simple Goal\nName: {GetShortName()}\nDescription: {GetDescription()}\n" +
               $"Completion Status: {(IsComplete() ? "Completed" : "Not Completed")}\nPoints: {GetPoints()}\n";
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }


}