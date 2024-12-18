using System;

public class ChecklistGoal : Goals
{
    private int _targetTime{ get; set; }
    private int _amountAccomplished{ get; set; }
    private int _bonus{ get; set; }
    public ChecklistGoal(string name, string description, int points, int targetTime, int amountAccomplished, int bonus)
    : base(name, description, points){
        _targetTime = targetTime;
        _amountAccomplished = amountAccomplished;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        _amountAccomplished++;
        if (_amountAccomplished >= _targetTime)
        {
            return _points + _bonus;
        }
        return _points;
    }
    public override bool IsAccomplished()
    {
        return _amountAccomplished >= _targetTime;
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal|{_name}|{_description}|{_points}|{_targetTime}|{_amountAccomplished}|{_bonus}";
    }
    public override string GetDetailString()
    {
        return $"[{(_amountAccomplished >= _targetTime ? "X" : " ")}] {_name} - {_description} ({_amountAccomplished}/{_targetTime})";
    }
}