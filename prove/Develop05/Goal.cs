using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Text;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

   

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        
        return _points;
    }

    public void SetPoints(int points)
    {

        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete(); 

    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}).";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}).";
        }
    }   
    
    public abstract string GetStringRepresentation();
}