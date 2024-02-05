using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(10);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You can begin in...");

        // Countdown before starting the activity
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

        // Get responses from the user
        List<string> entries = GetListFromUser();
        // Count the number of entries
        _count = entries.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed: {_count} items");
        
        // Display ending message
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        int listingTime = GetDuration(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(listingTime);

        List<string> entries = new List<string>();
        while (DateTime.Now < endTime)
        {
            string entry = Console.ReadLine();
            entries.Add(entry);
        }

        return entries;
    }
}
