//parent class for the other goal classes

using System;
//turning this into  an abstract class makes this work better
public abstract class Goal
{
    protected string _title;
    protected string _desc;
    protected int _points;
    protected bool _isComplete;
    public bool IsComplete()
    {
        return _isComplete;
    }
    protected DateTime _dateCreated = DateTime.Now;

    //creates a new goal
    public abstract void CreateGoal();
    //prints list
    public abstract string GetDisplayText();
    //updates score
    public abstract int RecordEvent();

    public abstract void LoadData(string[] parts);

    public virtual string SaveFormat()

    {
        return $"{_title}|{_desc}|{_points}|{_isComplete}";
    }
    

}
