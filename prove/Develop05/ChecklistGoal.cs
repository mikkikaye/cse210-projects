using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _goalCount;

    public ChecklistGoal(string name, string description, int points, int goalCount, int bonusPoints) : base(name, description, points)
    {
        _goalCount = goalCount;
        _bonusPoints = bonusPoints;
    }
    public override int Complete()
    {
        _goalCount--;
        int totalPoints = 0;

        if (_goalCount <= 0)
        {
            _complete = true;
            totalPoints = _points + _bonusPoints;
        }
        else
        {
            totalPoints = _points;
        }
        return totalPoints;
    }
    public override string GetGoalAsCSV()
    {
        string goalEvent = $"Checklist|{_name}|{_description}|{_points}|{_complete}|{_goalCount}|{_bonusPoints}";
        return goalEvent;
    }
        public new void DisplayGoal()
    {
        string status = "";
        if (_complete)
        {
            status = "[X]";
        }
        else 
        {
            status = "[ ]";
        }
        Console.WriteLine($"{_name}: {status}\n{_description}\nPoint Value: {_points}. You have {_goalCount} times left to complete this goal.");
    }

}