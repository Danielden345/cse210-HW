using System;

class Running : Activity
{
    private double _distance{ get; set; }
    public Running(string date, int duration, double distance) 
    : base(date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / (_distance / 60.0);
    }
    public override double GetPace()
    {
        return _duration / _distance;
    }
    
    
}