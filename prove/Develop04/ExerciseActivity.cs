using System;
using System.Diagnostics;

public class ExerciseActivity : Activity
{
    public ExerciseActivity()
    {
        _time = 0;
        _activityName = "Pre-Meditation Excercise Activity";
        _startMessage = $"Welcome to the {_activityName}!";
        _endMessage = $"Well done!\nYou have completed another {_time} of the {_activityName}";
        _description = "This activity will help you prepare for a meditation by walking your through some exercises to do beforehand.";
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
            Countdown(6, "Do 5 jumping jacks . . .");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);
            Countdown(6, "Run in place . . .");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);
            Countdown(6, "Do 5 sit ups . . .");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);
            Countdown(6, "Lay on your back and clench all your muscles . . .");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);
            Countdown(6, "Relax all your muscles now . . .");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, Console.CursorTop);

        }
        Console.WriteLine();
        EndMessage();
    }
}