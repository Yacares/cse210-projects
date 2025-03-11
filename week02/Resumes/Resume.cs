using System;


public class Resume
{
   public string _name;
   public List<Job> _jobs = new List<Job>();
 
   
   public void DisplayResumeDetails()
   {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs)
{
        job.DisplayJobDetails();
}


   }
   
}








// Create a new file for your Resume class. Each class should be in its own file and the file name should match the name of the class.
// Create the Resume class.
// Create the member variable for the person's name.
// Create the member variable for the list of Jobs. (Hint: the data type for this should be List<Job> , and it is probably easiest to initialize this to a new list right when you declare it..)