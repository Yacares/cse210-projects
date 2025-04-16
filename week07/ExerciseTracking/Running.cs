using System.Reflection.Metadata.Ecma335;

public class Running : Activity
{
    private double _distance;


    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double pace = (GetDuration() / GetDistance());
        return pace;
    }


}