using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("11 Dec 2025", 30f, 3f);

        Cycling cycling = new Cycling("10 Dec 2025", 45f, 12f);
        Swimming swimming = new Swimming("09 Dec 2025", 40f, 50);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine(activities[i].GetSummary());
            Console.WriteLine();
        }
    }
}