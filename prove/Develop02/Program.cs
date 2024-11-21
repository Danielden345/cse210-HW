using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string input = "";
        while (input != "5"){
            Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine("Welcome to Journal.1:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do today?");
            input = Console.ReadLine();
            switch(input){
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    return;
                case "3":
                    journal.Load();
                    break;
                case "4":
                    journal.Save();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid response. Please enter a number 1 - 5.");
                    break;
            }
        }
    }
}