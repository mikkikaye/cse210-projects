using System;
using System.Diagnostics;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected string _startMessage;
    protected string _endMessage;
    protected int _time;
    protected int _spinnerCounter;
    
    public Activity()
    {
        _time = 0;
        _activityName = "activity";
        _startMessage = $"Welcome to the {_activityName}!";
        _description = "description";
        _spinnerCounter = 0;
    }

    public void StartMessage()
    {
        Console.WriteLine(_startMessage);
        Console.WriteLine(_description);
    }
    public void EndMessage()
    {
        Console.WriteLine(string.Format("Well done!\nYou have completed {0} seconds of the {1}", _time, _activityName));
    }
    public void SetTime()
    {
        Console.WriteLine("In seconds, how long would you like your session to be?");
        string userInput = Console.ReadLine();
        _time = int.Parse(userInput);
    }
    public void Countdown(int time, string prompt)
    {
        for (int i = time; i >= 1; i--)
        {
            Console.Write(string.Format("{0} {1}", prompt, i));
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }
    public void DisplaySpinner(int time)
    {
        Console.WriteLine("Get Ready . . . ");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
    }
    public void RunActivity()
    {
        
    }
}

