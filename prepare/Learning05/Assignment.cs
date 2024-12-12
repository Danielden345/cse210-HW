using System;

public class Assignment{
    public string _studentName{ get; private set;}
    public string _topic{get; private set;}
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}