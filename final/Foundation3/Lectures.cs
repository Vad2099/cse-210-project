using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Lectures: Event
{
    private string _speaker;
    private int _capacity;

     public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        Console.WriteLine();
        return _speaker;
        
    }

    public int GetCapacity()
    {
        Console.WriteLine();
        return _capacity;
    }

    public string GetFullDetailsLectures()
    {
        return GetStandardDetails() + $"Speaker: {_speaker}\n Capacity: {_capacity.ToString()}\n";
    }

    public string GetShortLecturesDescription()
    {
        return $"Type of Event: Lecture\nTitle: {GetShortDescription()}";
    }

    
}

