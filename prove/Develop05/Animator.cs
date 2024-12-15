using System;
using System.Threading;

public class Animator{
    public void DisplaySpinner(int waitSeconds){
        string[] spinner = {"/","-","|","\\"};
        int spinnerIndex = 0;
        int totalIterations = waitSeconds * 10; // 10 iterations per second
        int sleepDuration = 3000 / totalIterations; // Total 3000 milliseconds divided by total iterations
        
        for(int i = 0; i < waitSeconds * 10; i++){
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(sleepDuration * 2);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
    }
    public void DisplayCountdown(int waitSeconds)
    {
        for (int i = waitSeconds; i> 0; i--){
        Console.Write(i);
        Thread.Sleep(1000);
        Console.SetCursorPosition(Console.CursorLeft - i.ToString().Length, Console.CursorTop);
        }
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        Console.Write(" ");
    }
}