using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int squaredNumber = SquareNumber(PromptUserNumber());
        string strSquared = squaredNumber.ToString();
        DisplayResult(userName, strSquared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int favNum = int.Parse(input);
        return favNum;
    }

    static int SquareNumber(int favNum)
    {
        int squared = favNum * favNum;
        return squared;
    }

    static void DisplayResult(string name, string squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared} ");  
    }
}
