using System;

public class Swimming : Activity
{
    public Swimming(double distance, double duration, DateTime date) : base(distance, duration, date)
    {
        _distance = distance;
        _duration = duration;
        _date = date;
    }
    public override double CalcSpeed()
    {
        double _speed = (CalcDistance() / _duration) * 60;
        return _speed;
    }
    public override double CalcPace()
    {
        double _pace = _duration / CalcDistance();
        return _pace;
    }
    public override double CalcDistance()
    {
        double swamDistance = _distance * 50 / 1000 * 0.62;
        return swamDistance;
    }
        public new string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min.)-- Distance: {this.CalcDistance()} miles, Speed: {this.CalcSpeed():F2} mph, Pace: {this.CalcPace():F2} min per mile";
    }
}