// This program exceeds the requirements by adding a custom spinner progress bar

using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("How many seconds would you like for this activity? ");
                int duration = int.Parse(Console.ReadLine());

                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax...", duration);
                breathing.Run();
            }
            else if (choice == "2")
            {
                Console.Write("How many seconds would you like for this activity? ");
                int duration = int.Parse(Console.ReadLine());

                ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect...", duration);
                reflecting.Run();
            }
            else if (choice == "3")
            {
                Console.Write("How many seconds would you like for this activity? ");
                int duration = int.Parse(Console.ReadLine());

                ListingActivity listing = new ListingActivity("Listing", "This activity will help you think positively...", duration);
                listing.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}



