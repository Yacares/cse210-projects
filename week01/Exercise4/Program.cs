using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)


    {
        int repeat = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int newNumber = int.Parse(input);
            if (newNumber == 0)
            {
                repeat = 0;
            }
            else
            {
                numbers.Add(newNumber);
            }

        } while (repeat != 0);


        int sumNumber = 0;
        int amountInList = 0;
        int maxNum = 0;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sumNumber = numbers.Sum();
            amountInList = numbers.Count;
            maxNum = numbers.Max();
        }

        float average = (float)sumNumber / amountInList;
        Console.WriteLine($"The sum is: {sumNumber}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNum}");

    }
}

