using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    private int _intervalSeconds{get; set;}
    Animator animator = new Animator();
    public BreathingActivity(string name, string introduction, int duration, string activity, int intervalSeconds) : base(name, introduction, duration, activity)
    {
        _intervalSeconds = intervalSeconds;
    }
    public void BreatheIn(){
        Console.Write("Breath In\n");
        animator.DisplayCountdown(4);
    }
    public void BreatheOut(){
        Console.Write("Now Breath Out...\n");
        animator.DisplayCountdown(6);
    }
    public void DoActivity() 
    {   Console.Clear();
        Console.WriteLine(DisplayIntroduction("Welcome to the Breathing Activity. ","This activity will help you relax by walking you through breathing in and out slowly. Clear your\nmind and focus on your breathing.")); 
        RequestActivitySeconds(); 
        Console.Clear();
        DisplayGetReady();
        Console.WriteLine("");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            BreatheIn();
            Console.WriteLine("");
            BreatheOut();
            Console.WriteLine("");
        }
        stopwatch.Stop();
        Console.WriteLine(DisplayClosing("Breathing Activity")); 
        Console.Clear();
        }
}