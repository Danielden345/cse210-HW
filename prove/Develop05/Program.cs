using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        string input = "";
        // Counters for each activity
        int breathingActivityCount = 0;
        int reflectingActivityCount = 0;
        int listingActivityCount = 0;

        while (input != "4"){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            input = Console.ReadLine();
            switch(input){
                case "1":
                    BreathingActivity breathe = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0, "Breathing Activity", 4);
                    breathe.DoActivity();
                    breathingActivityCount++;
                    break;
                case "2":
                    ReflectionActivity reflect = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection Activity", 0, new List<string>(), new List<string>());
                    reflect.DoActivity();
                    reflectingActivityCount++;
                    break;
                case "3":
                    ListingActivity list = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, "Listing Activity");
                    list.DoActivity();
                    listingActivityCount++;
                    break;
                case "4":
                    break;
                default: 
                    Console.WriteLine("Invalid response. Please enter a number 1 - 4.");
                    break;
            }
        }
        Console.WriteLine($"\nActivity Counts:");
        Console.WriteLine($"Breathing Activity: {breathingActivityCount}");
        Console.WriteLine($"Reflecting Activity: {reflectingActivityCount}");
        Console.WriteLine($"Listing Activity: {listingActivityCount}\n");
    }
}