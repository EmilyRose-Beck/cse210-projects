using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _targetAmount;
    private int _amountCompleted;
    private int _bonus;

    public override string GetDisplayText()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_title} ({_desc}) --- {_amountCompleted}/{_targetAmount} completions";

    }

    public override int RecordEvent()
    {
        if (_isComplete) return 0;

        _amountCompleted++;

        if (_amountCompleted >= _targetAmount)
        {
            _isComplete = true;
            return _points + _bonus;
        }

        return _points;
    }

    public override string SaveFormat()
    {
        return $"Checklist Goal|{_title}|{_desc}|{_points}|{_amountCompleted}|{_targetAmount}|{_bonus}|{_isComplete}";
    }

    public override void LoadData(string[] parts)
    {
        _title = parts[1];
        _desc = parts[2];
        _points = int.Parse(parts[3]);
        _amountCompleted = int.Parse(parts[4]);
        _targetAmount = int.Parse(parts[5]);
        _bonus = int.Parse(parts[6]);
        _isComplete = bool.Parse(parts[7]);
    }

    public override void CreateGoal()
    {
        Console.Write("Enter title: ");
        _title = Console.ReadLine();

        Console.Write("Enter description: ");
        _desc = Console.ReadLine();

        Console.Write("Points for each event: ");
        _points = int.Parse(Console.ReadLine());

        Console.Write("How many times must this be completed? ");
        _targetAmount = int.Parse(Console.ReadLine());

        Console.Write("Bonus points after full completion: ");
        _bonus = int.Parse(Console.ReadLine());

        _amountCompleted = 0;
        _isComplete = false;
    }
}
