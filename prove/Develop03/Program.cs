using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Load scriptures from a file
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        // Randomly select a scripture to present to the user
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Display the selected scripture
        DisplayScripture(scripture);

        // Main loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide random words
            scripture.HideRandomWords(3);

            // Clear console and display the scripture again
            Console.Clear();
            DisplayScripture(scripture);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine("Scripture Reference: " + scripture.GetReferenceDisplayText());
        Console.WriteLine("Scripture Text: " + scripture.GetDisplayText());
    }

    static List<Scripture> LoadScripturesFromFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        Reference reference = ParseReference(parts[0]);
                        scriptures.Add(new Scripture(reference, parts[1]));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading scriptures from file: " + ex.Message);
        }

        return scriptures;
    }

    static Reference ParseReference(string referenceText)
    {
        string[] parts = referenceText.Split(':');
        if (parts.Length == 2)
        {
            string[] bookChapter = parts[0].Split(' ');
            if (bookChapter.Length == 2)
            {
                string book = bookChapter[0];
                int chapter;
                int.TryParse(bookChapter[1], out chapter);

                string[] verseParts = parts[1].Split('-');
                int verse;
                int endVerse;
                if (verseParts.Length == 1)
                {
                    int.TryParse(verseParts[0], out verse);
                    return new Reference(book, chapter, verse);
                }
                else if (verseParts.Length == 2)
                {
                    int.TryParse(verseParts[0], out verse);
                    int.TryParse(verseParts[1], out endVerse);
                    return new Reference(book, chapter, verse, endVerse);
                }
            }
        }
        throw new ArgumentException("Invalid reference format: " + referenceText);
    }
}
