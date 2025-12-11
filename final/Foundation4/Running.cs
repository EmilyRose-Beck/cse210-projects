using System;
using System.Collections.Specialized;

public class Running : Activity
{

    public Running(string date, float minutes, float distance)
        : base(date, minutes, distance)
    {
        
    }

    //+ override GetDistance()
    public override float GetDistance()
    {
        return _distance;
    }
    //+ override GetPace()
    public override float GetPace()
    {
        return _minutes / _distance;
    }

    public override float GetSpeed()
    {
        return _distance / (_minutes / 60);
    }
}