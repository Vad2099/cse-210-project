using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}.");
        Thread.Sleep(2000);

        Console.WriteLine($"{_description}");
        Thread.Sleep(2000);
        Console.WriteLine();
       

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You have completed the {_name} activity.");
        Thread.Sleep(2000);
        Console.WriteLine($"Activity duration: {_duration} seconds");
        ShowSpinner(10);
    }

    public void ShowSpinner(int seconds)
    {
        List<string>animationSpinner = new List<string>();

        animationSpinner.Add("|");
        animationSpinner.Add("/");
        animationSpinner.Add("-");
        animationSpinner.Add("\\");
        animationSpinner.Add("|");
        animationSpinner.Add("/");
        animationSpinner.Add("-");
        animationSpinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationSpinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationSpinner.Count)
            {
                i = 0;
            }
        }
    } 

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }


}