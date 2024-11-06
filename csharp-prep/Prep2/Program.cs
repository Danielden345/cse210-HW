using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);
        string letter = percent switch{
            >= 97 => "A+",
            >= 93 => "A",
            >= 90 => "A-",
            >= 87 => "B+",
            >= 83 => "B",
            >= 80 => "B-",
            >= 77 => "C+",
            >= 73 => "C",
            >= 70 => "C-",
            >= 67 => "D+",
            >= 63 => "D",
            >= 60 => "D-",
            _ => "F"

        };

        // if (percent >= 90){
        //     if (percent >= 97){
        //         letter = "A+";
        //     }
        //     else if (percent >= 93){
        //         letter = "A";
        //     }
        //     else{
        //         letter = "A-";
        //     }
        // } 

        // else if(percent >= 80){
        //     if (percent >= 87){
        //         letter = "B+";
        //     }
        //     else if (percent >=83){
        //         letter = "B";
        //     }
        //     else{
        //         letter = "B-";
        //     }
        // }

        // else if(percent >= 70){
        //     if (percent >= 77){
        //         letter =  "C+";
        //     }
        //     else if (percent >= 73){
        //         letter =  "C";
        //     }
        //     else{
        //         letter =  "C-";
        //     }
        // }

        // else if(percent >= 60){
        //     if (percent >= 67){
        //         letter =  "D+";
        //     }
        //     else if (percent >= 63){
        //         letter =  "D";
        //     }
        //     else{
        //         letter =  "D-";
        //     }
        // }

        // else{
        //     letter = "F";
        // }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (percent >= 70){
            Console.WriteLine("Amazing, you have passed the class!");
        }

        else {
            Console.WriteLine("Please sign up for next semester.");
        }
    }
}