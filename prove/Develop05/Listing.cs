using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ListingActivity : Activity 
{
    Random random = new Random();
    Animator animator = new Animator();
    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _inputs = new List<string>(){};
    public ListingActivity(string name, string introduction, int duration, string activity)
    : base(name, introduction, duration, activity){    }

    public string DisplayPrompt(){
        int i = random.Next(0, _prompts.Count);
        return $"{_prompts[i]}";
    }
    public void GetInputs(){
        Console.Write("> ");
        _inputs.Add(Console.ReadLine());
    }
    public void DisplayResult(){
        Console.WriteLine($"You listed {_inputs.Count} items.");
    }
    public void DoActivity(){
        Console.Clear();
        Console.WriteLine(DisplayIntroduction("Welcome to the Listing Activity","This activity will help you reflect on the good things in your life by having you list as many \nthings as you can in a certain area."));
        RequestActivitySeconds();
        Console.Clear();
        DisplayGetReady();
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {DisplayPrompt()} --- ");
        Console.Write($"You may begin in:");
        animator.DisplayCountdown(5);
        Console.WriteLine("");
        Console.WriteLine("Start listing items. Press Enter after each item.");

        int elapsedTime = 0;
        DateTime startTime = DateTime.Now;

        while (elapsedTime < _duration)
        {
            GetInputs();
            elapsedTime = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        DisplayResult();
        DisplayClosing("Listing Activity");
        Console.Clear();
    }
}