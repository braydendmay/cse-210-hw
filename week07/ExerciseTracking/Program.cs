
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
            {
                // instance for each activity
                new Running(new DateTime(2025, 2, 18), 30, 4.8),
                new Cycling(new DateTime(2025, 2, 18), 30, 20.0),
                new Swimming(new DateTime(2025, 2, 18), 30, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
    }
}