using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override int Complete()
    {
        return _points;
    }
    public override string GetGoalAsCSV()
    {
        string goalEvent = $"Perpetual|{_name}|{_description}|{_points}|{_complete}|0|0";
        return goalEvent;
    }
}