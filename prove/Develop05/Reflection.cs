using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
public class ReflectionActivity : Activity
{
    Animator animator = new Animator();
    Random random = new Random();
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity(string name, string introduction, string activity, int duration, List<string> prompts, List<string> questions)
    : base(name, introduction, duration, activity) {}
    public string DisplayPrompt(){
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }
    public void PrepareToPonder(){
        Console.Write($"Now ponder on each of the following questions as they related to this experience.\n\nYou may begin in: ");
        
    }
    public string DisplayQuestion(){
        int i = random.Next(0, _questions.Count);
        return $"> {_questions[i]}";
    }
    public void DoActivity(){
        Console.Clear();
        Console.WriteLine(DisplayIntroduction("Welcome to the Reflection Activity. ","This activity will help you reflect on times in your life when you have shown strenght and\nresilience. This will help you recognize the power you have and how you can use it in other aspects of your\nlife.")); 
        RequestActivitySeconds();
        Console.Clear();
        DisplayGetReady();
        Console.WriteLine(""); 
        Console.WriteLine("Conside the following prompt:\n");
        Console.WriteLine($" ---- {DisplayPrompt()} ----\n");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        PrepareToPonder();
        animator.DisplayCountdown(5);
        Console.Clear();
        int elapsedTime = 0; 
        while (elapsedTime < _duration) 
        {
            Console.WriteLine(DisplayQuestion());         
            animator.DisplaySpinner(1);
            elapsedTime += 10;
        } 
        Console.WriteLine(DisplayClosing("Reflecting Activity")); 
        Console.Clear();
    }
}