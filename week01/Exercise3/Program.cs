using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        string answer = "";
        string h = "Higher";
        string l = "Lower";
        string r = "You guessed it!";
        Random randomGenerator = new Random();
        int tries = 0;

        while (playAgain)
        {

            int magicNum = randomGenerator.Next(1, 100);
            tries = 0;

            do
            {
                Console.WriteLine(" What is the your guess?");
                string input2 = Console.ReadLine();
                int guess = int.Parse(input2);

                if (magicNum > guess)
                {
                    answer = h;
                }
                else if (magicNum < guess)
                {
                    answer = l;
                }
                else
                {
                    answer = r;
                }

                Console.WriteLine(answer);
                tries += 1;

            } while (answer != r);


            Console.WriteLine($"It took you {tries} tries");

            Console.WriteLine("Would you like to continue playing? Write 'y' for Yes or 'n' for No: ");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                playAgain = true;
            }

            else if (input == "n")
            {
                playAgain = false;
            }
            else
            {
                Console.WriteLine("Invalid input! Assuming you want to exit.");
                playAgain = false;
            }

        }

        Console.WriteLine("Thank you for playing!");
    }
}
