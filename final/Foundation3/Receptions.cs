using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Receptions: Event
{
    private string _rsvpEmail;

    public Receptions(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetailsReceptions()
    {
        return GetStandardDetails() + $"RSVP Email: {_rsvpEmail}\n";
    }

     public string GetShortReceptionsDescription()
    {
        return $"Type of Event: Reception\nTitle: {GetShortDescription()}";
    }
}