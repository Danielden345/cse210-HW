using System;

public class WritingAssignment : Assignment
{
    private string _title{ get; set; }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic){
        _title = title;
    }
    public string GetWritinginformation(){
        return _title;
    }
}