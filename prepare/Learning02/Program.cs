using System;




class Program
{
    static void DisplayJobDetails(){

    }
    static void Main()
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Electrician";
        job1._company = "Delta Electric";
        job1._startYear = 2023;
        job1._endYear = 2024;
        Job job2 = new Job();
        job2._jobTitle = "Sandwich Artist";
        job2._company = "Subway";
        job2._startYear = 2020;
        job2._endYear = 2021;
        Resume yourResume  = new Resume();
        yourResume._name = "John Stanton";
        yourResume._jobs.Add(job1);
        yourResume._jobs.Add(job2);
        yourResume.Display();

    }
}