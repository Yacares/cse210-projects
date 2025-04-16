public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"The Eternal Goal '{GetShortName()}' is completed!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"Goal Type: Eternal Goal\nName: {GetShortName()}\nDescription: {GetDescription()}\n" +
             $"Completion Status: {(IsComplete() ? "Completed" : "Not Completed")}\nPoints: {GetPoints()}\n";
    }

    public override string GetStringRepresentation()
    {
       return $"EternalGoal,{GetShortName()},{GetDescription()},{GetPoints()},false";
    }

}