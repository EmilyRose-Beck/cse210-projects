public class EnternalGoal : Goal
{
    public override string GetDisplayText()
    {
        return $"{_title} ({_desc})";
    }
    public override int RecordEvent()
    { // Eternal goals always award points each time
        return _points;
    }
    //how we save
    public override string SaveFormat()
    {
        return $"Enternal Goal|{_title}|{_desc}|{_points}";
    }

    public override void LoadData(string[] parts)
    {
        _title = parts[1];
        _desc = parts[2];
        _points = int.Parse(parts[3]);
    }

    public override void CreateGoal()
    {
        Console.Write("Enter title: ");
        _title = Console.ReadLine();

        Console.Write("Enter description: ");
        _desc = Console.ReadLine();

        Console.Write("Points for every time it is completed: ");
        _points = int.Parse(Console.ReadLine());

        _isComplete = false;
    }
}
