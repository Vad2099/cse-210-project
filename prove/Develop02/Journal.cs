using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;
    private PromptGenerator _promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        _promptGenerator = new PromptGenerator();
    }

    public void AddEntry()
    {
        Entry newEntry = new Entry(_promptGenerator);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date},{entry.PromptText},{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear(); // Clear existing entries before loading new ones

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts.Length == 3)
            {
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];

                Entry loadedEntry = new Entry(date, promptText, entryText);
                _entries.Add(loadedEntry);
            }
            else
            {
                Console.WriteLine($"Invalid line format: {line}");
            }
        }
    }
}