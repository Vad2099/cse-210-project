using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class Event
{
    private string _eventTitle;
    private string _description;
    private DateTime _date; // Cambiado a DateTime
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = DateTime.Parse(date); // Convertir la cadena de fecha a DateTime
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToString("yyyy-MM-dd")}\nTime: {_time}\nAddress: {_address.GetAddressDetails()}";
    }

  

    public virtual string GetShortDescription()
    {
        return $"Title: {_eventTitle}\nDate: {_date}";
    }
}