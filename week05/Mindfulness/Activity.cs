public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting: {_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner =
        {

        "▒▒▒▒▒▒▒▒▒▒ 0%",
        "█▒▒▒▒▒▒▒▒▒ 10%",
        "██▒▒▒▒▒▒▒▒ 20%",
        "███▒▒▒▒▒▒▒ 30%",
        "████▒▒▒▒▒▒ 40%",
        "█████▒▒▒▒▒ 50%",
        "██████▒▒▒▒ 60%",
        "███████▒▒▒ 70%",
        "████████▒▒ 80%",
        "█████████▒ 90%",
        "██████████ 100%"

        };

        int totalFrames = spinner.Length;
        int delay = (seconds * 1000) / totalFrames;

        for (int i = 0; i < totalFrames; i++)
        {
            Console.Write($"\r{spinner[i]}   ");
            Thread.Sleep(delay);
        }

        Console.WriteLine();

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }
}
