using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class OutdoorGatherings : Event
{
    private string _weatherForecast;

    public OutdoorGatherings(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullOutdoorGatheringsDetails()
    {
        return GetStandardDetails() + $"Weather Forecast: {_weatherForecast}\n";
    }

    public string GetShortFullOutdoorGatheringsDescription()
    {
        return $"Type of Event: Reception\nTitle: {GetShortDescription()}";
    }
}