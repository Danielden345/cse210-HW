using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class Journal
{
    List<Entry> _journal = new List<Entry>();
    string filePath = "journal.txt";
    public void AddEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string newPrompt = prompt.GeneratePrompt();
        Console.WriteLine(newPrompt); // Display the generated prompt to the user
        string text = Console.ReadLine();

        // Create a new Entry object
        Entry entry = new Entry(DateTime.Now, newPrompt, text);

        // Display the entry
        entry.Display();

        // Add the entry to the journal
        _journal.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _journal){
            entry.Display();
        } // cycles through the list of entries
    }
    public void Save(){
        
        try
        {
            // Open or create the file for appending text
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                foreach (Entry entry in _journal)
                {
                    // Serialize each entry as a string and append it to the file
                    string entryContent = $"{entry._now:yyyy-MM-dd} - {entry._promptText}: {entry._entryText}";
                    writer.WriteLine(entryContent);
                }
            }

            Console.WriteLine("Journal entries saved successfully.");
        }
        catch (Exception ex)
        {
            // Handle potential errors like file access issues
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }
    public void Load(){
        if (File.Exists(filePath) ){
                // read lines from filePath
                string[] lines = File.ReadAllLines(filePath);
        }
        else{
            Console.WriteLine("No journal entries were found. Please select 1 to input an entry.");
        }
    }
}