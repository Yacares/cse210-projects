using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running a1 = new Running("23 Sep 2024", 45, 5 );
        activities.Add(a1);
        Cycling a2 = new Cycling("06 Oct 2020", 20, 3 );
        activities.Add(a2);
        Swimming a3 = new Swimming("25 Jun 2019", 60, 50 );
        activities.Add(a3);


        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    

    }
}