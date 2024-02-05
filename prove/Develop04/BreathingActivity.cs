using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(10);

        int breathTime = GetDuration(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(breathTime);

        while (DateTime.Now < endTime)
        {
            // Breathe in
    
            for (int i = 4; i > 0; i--)
            {
                Console.Write("Breathe in...");
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Clear();
            }

            // Breathe out
            
            for (int i = 4; i > 0; i--)
            {
                Console.Write("Breathe out...");
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Clear(); 
            }
        }
        
        Thread.Sleep(3000);
        Console.WriteLine();
        DisplayEndingMessage();
    }
}
