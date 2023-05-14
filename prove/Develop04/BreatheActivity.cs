using System;
using System.Diagnostics;

public class BreatheActivity : Activity
{
    public BreatheActivity()
    {
        _time = 0;
        _activityName = "Breathe Activity";
        _startMessage = $"Welcome to the {_activityName}!";
        _endMessage = $"Well done!\nYou have completed another {_time} of the {_activityName}";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _spinnerCounter = 0;
    }
    public new void RunActivity()
    {
        StartMessage();
        SetTime();
        DisplaySpinner(5);
        Countdown(5, "You may begin in . . .");
        Console.WriteLine();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < _time)
        {
            Countdown(6, "Breathe in . . . ");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);
            Countdown(6, "Breathe out . . . ");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        Console.WriteLine();
        EndMessage();
    }
}