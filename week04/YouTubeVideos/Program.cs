using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Epic Fails 2025", "FailArmy", 300),
            new Video("Tech Review: New Gadgets", "TechGuru", 600),
            new Video("Best Cooking Tips", "ChefMaster", 450)
        };

        videos[0].AddComment("Alice", "Haha, this was hilarious!");
        videos[0].AddComment("Bob", "Omg, that last fall was crazy!");
        videos[0].AddComment("Charlie", "I love watching these compilations.");

        videos[1].AddComment("David", "Great review, I’m considering buying this.");
        videos[1].AddComment("Emma", "You forgot to mention battery life.");
        
        videos[2].AddComment("Sophia", "Amazing tips! Tried this recipe and it was delicious.");
        videos[2].AddComment("Jack", "Can you do a tutorial for beginners?");
        videos[2].AddComment("Liam", "I learned so much, thanks!");


        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }

}