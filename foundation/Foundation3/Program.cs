using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        List<Activity> activities = new List<Activity>()
        {
            new Running("21 Oct 2023", 30, 3.4),
            new Cycling("21 Oct 2023", 30, 12.0),
            new Swimming("21 Oct 2023", 30, 22)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}