using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

public class CheckListGoal : Goal
{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) :base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_target == _amountCompleted)
       {
        int totalPoints = GetPoints() + _bonus;
        SetPoints(totalPoints);
       }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
           
            return true;
        
        } else

        {

        return false;
        }
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
    {
        return $"[X] {GetName()} ({GetDescription()}) --- Completed";
    }
    else
    {
        return $"[ ] {GetName()} ({GetDescription()}) --- Currently completed: {_amountCompleted}/{_target}";
    }
    }


    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }
}