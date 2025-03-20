// I used a loop to cycle the different files that the user will be able to select while loading and I also added an
// automatic extension while saving

using System;
using System.IO;

class Program
{


    static void Main(string[] args)
    {

        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;

        while (true)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");

            string input = Console.ReadLine();



            if (input == "1")
            {
                string promptText = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {promptText}");
                Console.Write("Your response: ");
                string entryText = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = theCurrentTime.ToString("MM-dd-yyyy"),
                    _promptText = promptText,
                    _entryText = entryText
                };
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added!\n");
            }
            else if (input == "2")
            {
                myJournal.DisplayAll();
            }
             else if (input == "3")
            {
                myJournal.LoadFromFile();
                myJournal.DisplayAll();
            }
            else if (input == "4")
            {
                Console.Write("Please write a file name to save: ");
                string name = Console.ReadLine();
                myJournal.SaveToFile(name + ".csv");
            }
            else if (input == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}