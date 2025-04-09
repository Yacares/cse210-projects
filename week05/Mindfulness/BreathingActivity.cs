public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
     
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < GetDuration() / 10; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(6);
        }
        DisplayEndingMessage();
    }
}