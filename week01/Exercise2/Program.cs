using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage:");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";
        string symbol = "";

        if (grade >= 90 && grade <= 100)
        {
            letter = "A";
        }

        else if (grade >= 80 && grade <= 89)
        {
            letter = "B";
        }

        else if (grade >= 70 && grade <= 79)
        {
            letter = "C";
        }

        else if (grade >= 60 && grade <= 69)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        if (grade % 10 > 5)
        {
            symbol = "+";
        }

        else if (grade % 10 < 5)
        {
            symbol = "-";
        }

        else
        {
            symbol = "";
        }

        if(letter == "A" && symbol == "+")
        {
            symbol = "";
        }

        if(letter == "F" && symbol == "+")
        {
            symbol = "";
        }

        else if (letter == "F" && symbol == "-")
        {
            symbol = "";
        }

        Console.WriteLine($"You have a/an '{letter}{symbol}'.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }

        else
        {
            Console.WriteLine("You need to try harder next time!");
        }

    }
}
