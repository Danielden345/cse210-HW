using System;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber(){
        Console.Write("Enter favorite number: ");
        return int.Parse(Console.ReadLine());
    } 
    static double SquareNumber(int fav_number){
        double squared = Math.Pow(fav_number, 2);
        return squared;
    } 
    static void DisplayResult(string name, double squared){
        Console.WriteLine($"{name}, the square of your number is {squared}. ");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int fav_number = PromptUserNumber();
        double squared = SquareNumber(fav_number);

        DisplayResult(name, squared);

    }
}