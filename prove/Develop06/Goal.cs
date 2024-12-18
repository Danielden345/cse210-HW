using System;

public abstract class Goals
{
    protected string _name{get;set;}
    protected string _description{get;set;}
    protected int _points{get;set;}
    public Goals (string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }
    public string Name => _name;
    public abstract int RecordEvent();
    public abstract bool IsAccomplished();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailString()
    {
        return $"[] {_name} - {_description}";
    }
}