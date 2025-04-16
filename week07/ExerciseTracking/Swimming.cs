public class Swimming : Activity
{
    private int _laps;


    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        double distance = GetLaps() * 50 / 1000.0;
        return distance;
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