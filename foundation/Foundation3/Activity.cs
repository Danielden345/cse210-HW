using System;

abstract class Activity
{
    protected string _date{get; set;}
    protected int _duration{get; set;}
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_duration} min) - Distance {GetDistance():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}