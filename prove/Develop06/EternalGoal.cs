using System;

public class EternalGoal : Goals
{
    public EternalGoal(string name, string description, int points)
    : base(name, description, points){}
    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsAccomplished()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal |{_name}|{_description}|{_points}";
    }
    public override string GetDetailString()
    {
        return base.GetDetailString();
    }
}