using System;

public class Activity
{
    protected DateTime _date;
    protected double _duration;
    protected double _distance;
    protected string _eventType;

    public Activity(double distance, double duration, DateTime date)
    {
        _distance = distance;
        _duration = duration;
        _date = date;
    }
    public virtual double CalcSpeed()
    {
        return 0;
    }
    public virtual double CalcPace()
    {
        return 0;
    }
    public virtual double CalcDistance()
    {
        return _distance;
    }
    public string GetSummary()
    {
        return $"{_date.ToString("MMMM dd, yyyy")} {this.GetType().Name} ({_duration} min.)-- Distance: {CalcDistance():F2} miles, Speed: {this.CalcSpeed():F2} mph, Pace: {this.CalcPace():F2} min per mile";
    }
}