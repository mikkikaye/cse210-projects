using System;

public class Goal
{
    protected bool _complete;
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }
    public bool GetComplete()
    {
        return _complete;
    }
    public virtual int Complete()
    {
        return 0;
    }
    public virtual string GetGoalAsCSV()
    {
        return "";
    }
    public void DisplayGoal()
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
        Console.WriteLine($"{_name}: {status}\n{_description}\nPoint Value: {_points}");
    }

}