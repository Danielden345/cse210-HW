using System;
using System.Runtime.CompilerServices;

class GoalManager
{
    private List<Goals> goals = new List<Goals>();
    private int _score{get; set;}
    private int _level;
    private int _pointsForNextLevel;
    
    public GoalManager (int score){
        _score = score;
        _level = 1;
        _pointsForNextLevel = 200;
    }

    public void Start(){
        bool running = true;
        while(running)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames(); 
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoal();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 - 6.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"Your score is currently: {_score}");
        Console.WriteLine($"Your level is currently: {_level}");
        Console.WriteLine($"Points needed for next level: {_pointsForNextLevel - _score}");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goals[i].Name}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("What typr of goal do you want to create? ");
        int type = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a small description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What are the points assigned to your goal? ");
        int points = int.Parse(Console.ReadLine());
        if (type == 1)
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2){
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.WriteLine("How many times do you want to complete the goal? ");
            int targetTime = int.Parse(Console.ReadLine());
            Console.WriteLine("How many points will you gain once you complete this activity? ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, description, points, targetTime, 0, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Enter the goal's number you completed: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
           int pointsEarned = goals[goalIndex].RecordEvent();
            _score += pointsEarned;
            CheckLevelUp();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    public void SaveGoal()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts[0] == "SimpleGoal"){
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if(parts[0] == "EternalGoal")
                {
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if(parts[0] == "ChecklistGoal")
                {
                    goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                }
                else
                {
                    Console.WriteLine("No saved goals were found.");
                }
            }
        }
        else{
            Console.WriteLine("No file was found.");
        }
    }
       private void CheckLevelUp()
    {
        while (_score >= _pointsForNextLevel)
        {
            _level++;
            _score -= _pointsForNextLevel;
            _pointsForNextLevel = CalculatePointsForNextLevel();
            Console.WriteLine($"Congratulations! You've reached level {_level}!");
        }
    }

    private int CalculatePointsForNextLevel()
    {
        // Example: Increase points required for next level by 50% each level
        return (int)(_pointsForNextLevel * 1.5);
    }
}