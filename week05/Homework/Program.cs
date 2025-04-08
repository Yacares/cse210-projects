using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment hw1 = new Assignment("John", "Math");
        Console.WriteLine(hw1.GetSummary());

        MathAssignment hw2 = new MathAssignment("Roberto Rodriguez","Fractions", "7.3", "8-19");
        Console.WriteLine(hw2.GetSummary());
        Console.WriteLine(hw2.GetHomeworkList());

        WritingAssignment hw3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II" );
        Console.WriteLine(hw3.GetSummary());
        Console.WriteLine(hw3.GetWritingInformation());
    }
}