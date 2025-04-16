public class Cycling : Activity
{
    private double _speed;


    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (GetSpeed() * GetDuration()) / 60;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = (GetDuration() / GetDistance());
        return pace;
    }

}