using System; 

public class Activity{
    private string _name{get; set;}
    private string _introduction{get; set;}
    protected int _duration{get; set;}
    protected string _activity{get; set;}
    Animator animator = new Animator();
    public Activity(string name, string introduction, int duration, string activity){
        _name = name;
        _introduction = introduction;
        _duration = duration;
        _activity = activity;
    }
    public string DisplayIntroduction(string name, string introduction){
        return $"{name}\n\n{introduction}\n";
    }
    public int RequestActivitySeconds(){
        Console.WriteLine("How long, in seconds, will you do this activity? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }
    public void DisplayGetReady()
    {
        Console.WriteLine("Get Ready...");
        animator.DisplayCountdown(5);
    }
    public string DisplayClosing(string activity){
        Console.Write($"Well done!\n\n You have completed {_duration} seconds of the {_activity}.\n");
        animator.DisplaySpinner(1);
        return "Activity completed.";
    }
}