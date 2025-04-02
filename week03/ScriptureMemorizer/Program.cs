// I made various scriptures and when one is finished, it continues with the next until all the scriptures where hidden or if the user inputs "quit"

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God"),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be and men are that they might have joy")
        };

        Random rand = new Random();
        
        while (scriptures.Count > 0) 
        {
            Scripture scripture = scriptures[rand.Next(scriptures.Count)]; 
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit") return;

                scripture.HideRandomWords(2); 
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }

            Console.WriteLine("\nAll words in this scripture are hidden. Selecting a new scripture...");
            scriptures.Remove(scripture); 
        }

        Console.WriteLine("\nAll scriptures are hidden. Program ending.");
    }
}
