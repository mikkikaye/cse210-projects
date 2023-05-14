using System; 

public class ReflectionActivity : Activity
{
    private string _prompt;
    private List<string> _questions;

    public ReflectionActivity()
    {
        _prompt = "When was a time you had to do something hard?";
        _questions = new List<string>()
        {
            "How did this make you feel?",
            "How did you react when this happened?",
            "How did you involve Heavenly Father in what happened?",
            "What did you learn from this event?"
        };
        _time = 0;
        _activityName = "Reflection Activity";
        _startMessage = $"Welcome to the {_activityName}!";
        _endMessage = $"Well done!\nYou have completed another {_time} of the {_activityName}";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _spinnerCounter = 0;
        }
    public void DisplayPrompt(string prompt)
    {
            Console.WriteLine(prompt);
    }
    public void DisplayQuestion()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(_time / _questions.Count() * 1000);
        }
    }
    public new void RunActivity()
    {
        StartMessage();
        SetTime();
        DisplaySpinner(5);
        Countdown(5, "You may begin in . . .");
        DisplayPrompt(_prompt);
        Console.WriteLine("Hit enter when you are ready to continue.");
        Console.ReadLine();
        DisplayQuestion();
        EndMessage();
    } 
}