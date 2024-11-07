using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do{
            // Start a new game
            Random randomgenerator = new Random();
            int magic_number = randomgenerator.Next(1, 101); // Generates a number between 1 - 100
            int guess;
            int count = 0; //Tracks number of guesses

            Console.WriteLine("What is the magic number? ");

            // Guessing loop
            do {
                Console.WriteLine("What is your guess? (1-100)");
                if (int.TryParse(Console.ReadLine(), out guess)){
                    count++;  // Increment guess count
                    if (guess > magic_number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guess < magic_number)
                    {
                        Console.WriteLine("Higher");
                    }
                }
                else{
                    Console.WriteLine("Please enter a valid number.");
                }
            } while (guess != magic_number);

            Console.WriteLine("You guessed it!");

            // Game over, display number of guesses
            Console.WriteLine($"You guessed it in {count} guesses!");

            // Ask if the user wants to play again
            Console.Write("Would you like to play again? (yes/no): ");
            response = Console.ReadLine().ToLower();  // Make the input case insensitive

        } while (response == "yes");

        Console.WriteLine("Thanks for playing! Hope you enjoyed the game!");
    }
}