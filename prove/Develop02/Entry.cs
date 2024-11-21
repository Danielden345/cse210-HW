using System;

public class Entry
{
    public DateTime _now = DateTime.Now;
    public string _promptText;
    public string _entryText;

    
    public Entry(DateTime now, string promptText, string entryText)
    {
        _now = now;
        _promptText = promptText;
        _entryText = entryText; 
    }
    public void Display()
    {
        Console.Write($"{_now:yyyy-MM-dd} - {_promptText} \n {_entryText}");

    }
}