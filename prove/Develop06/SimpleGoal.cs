using System;
using System.ComponentModel;
using System.Drawing;

class SimpleGoal : Goals
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points)
    : base(name, description, points){
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsAccomplished()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }
    public override string GetDetailString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} - {_description}";
    }
}