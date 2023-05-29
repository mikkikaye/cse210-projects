using System;

public class Running : Activity
{
    public Running(double distance, double duration, DateTime date) : base(distance, duration, date)
    {
        _distance = distance;
        _duration = duration;
        _date = date;
    }
    public override double CalcSpeed()
    {
        double _speed = (_distance / _duration) * 60;
        return _speed;
    }
    public override double CalcPace()
    {
        double _pace = _duration / _distance;
        return _pace;
    }
}