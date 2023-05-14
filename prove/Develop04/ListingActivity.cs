using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts;
        private int _responseCount;
    public ListingActivity()
    {
        _prompts = new List<string>()
        {
            "List the times you felt the spirit this week.",
            "List the times you have felt your testimony grow.",
            "List the times you were really frustrated with homework.",
            "List the times you were able to overcome a weakness."
        };
        _time = 0;
        _activityName = "Listing Activity";
        _startMessage = $"Welcome to the {_activityName}!";
        _endMessage = $"Well done!\nYou have completed another {_time} of the {_activityName}";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _spinnerCounter = 0;
        _responseCount = 0;
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int numberPrompts = random.Next(_prompts.Count);
        string randomPrompt = _prompts[numberPrompts];
        Console.WriteLine(randomPrompt);
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < _time)
        {
            string phrase = Console.ReadLine();
            _responseCount++;
        }
    }
    public void DisplayListCount()
    {
        Console.WriteLine($"You were able to list {_responseCount} things.");
    }
    public new void RunActivity()
    {
        StartMessage();
        SetTime();
        DisplaySpinner(5);
        Countdown(5, "You may begin in . . .");
        DisplayPrompt();
        DisplayListCount();
        EndMessage();
    }
}