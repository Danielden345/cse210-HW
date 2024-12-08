using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a book: ");
        string book = Console.ReadLine();
        Console.WriteLine("Please enter a chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the starting verse: ");
        int startVerse = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the ending verse(press enter if there is no more than 1 verse): ");
        int endVerse = int.Parse(Console.ReadLine());

        Console.WriteLine("Please type your verse(s) here. Hit enter once you are done typing.");
        string verse = Console.ReadLine();

        var reference = new Reference(book, chapter, startVerse, endVerse);
        var scripture = new Scriptures(reference, verse);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Memorize the scripture:");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Program ending.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input?.Trim().ToLower() == "quit") break;

            scripture.HideRandomWords();
        }
    }
}