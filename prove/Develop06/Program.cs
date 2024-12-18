using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");
        GoalManager manager = new GoalManager(0);
        manager.Start();
    }
}