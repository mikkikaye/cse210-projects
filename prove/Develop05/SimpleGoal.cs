using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override int Complete()
    {
        _complete = true;
        
        return _points;
    }
    public override string GetGoalAsCSV()
    {
        string goalEvent = $"Simple|{_name}|{_description}|{_points}|{_complete}|0|0";
        return goalEvent;
    }
}