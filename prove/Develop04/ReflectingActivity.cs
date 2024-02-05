using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    List<string> _prompts;
    List<string> _questions;



    public ReflectingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(10);
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue");
        Console.WriteLine("Now, ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You can begin in...");

        // Countdown before starting the activity
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

        int duration = GetDuration(); // Get the duration from the user
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            Thread.Sleep(5000); // Pause for 5 seconds between questions
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine();
        Console.Write(GetRandomQuestion()); 
        ShowSpinner(10); 
    }

}
