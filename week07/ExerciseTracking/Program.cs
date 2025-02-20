using System;
class Program
{
    static void Main(string[] args)
    {
        // Create different activity objects with getters and setters used to assign values
        var running = new Running(new DateTime(2022, 11, 3), 30, 5.0);          // running distance: 30 min, 5 km
        var cycling = new Cycling(new DateTime(2022, 11, 3), 45, 20.0);         // cycling speed: 45 min, 20 km/h
        var swimming = new Swimming(new DateTime(2022, 11, 3), 40, 40);         // swimming laps: 40 min, 40 laps

        // Put all activities into a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterate through each activity and print their summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}