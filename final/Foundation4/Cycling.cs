using System;

public class Cycling : Activity
{
    //- _speed: float
    private float _speed;

    public Cycling(string date, float minutes, float speed)
        : base (date, minutes, 0)
    {
        _speed = speed;
    }

    //+ override GetDistance()
    public override float GetDistance()
    {
        return _speed * (_minutes / 60);
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