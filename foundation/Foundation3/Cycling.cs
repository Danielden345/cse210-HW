using System;

class Cycling : Activity
{
    private double _speed{get;set;}
    public Cycling(string date, int duration,double speed ) 
    : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * (_duration / 60.0);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}