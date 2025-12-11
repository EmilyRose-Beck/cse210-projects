using System;

public class Swimming : Activity
{
    //- _laps
    private int _laps;
    public Swimming(string date, float minutes, int laps)
        : base (date, minutes, 0)
    {
        _laps = laps;
    }

    //+ override GetDistance()
    public override float GetDistance()
    {
        return _laps * 0.05f; // 50/1000 = .05
    }
    //+ override GetPace()
    public override float GetPace()
    {
        return _minutes / GetDistance();
    }

    public override float GetSpeed()
    {
        return GetDistance() / (_minutes / 60);
    }
}