public class SimpleGoal : Goal
{
    public override string GetDisplayText()     
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_title} ({_desc})";
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }
    //saves
    public override string SaveFormat()
    {
        return $"Simple Goal|{_title}|{_desc}|{_points}|{_isComplete}";
    }
    public override void LoadData(string[] parts)
    {
        _title = parts[1];
        _desc = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
    }  

    public override void CreateGoal()
    {
        Console.Write("Enter title: ");
        _title = Console.ReadLine();

        Console.Write("Enter description: ");
        _desc = Console.ReadLine();

        Console.Write("Points for completion: ");
        _points = int.Parse(Console.ReadLine());

        _isComplete = false;
    }

}
