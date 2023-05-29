using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Fitness App!");
        List<Activity> activities = new List<Activity>();

        Cycling cyclingActivity = new Cycling(10, 10, new DateTime(2023, 05, 27));
        activities.Add(cyclingActivity);
        
        Swimming swimmingActivity = new Swimming(10, 10, new DateTime(2023, 05, 28));
        activities.Add(swimmingActivity); 

        Running runningActivity = new Running(10, 10, new DateTime(2023, 05, 26));
        activities.Add(runningActivity);
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}\n");
        }
    }
}