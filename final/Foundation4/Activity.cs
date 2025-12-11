using System;

public abstract class Activity
{
    //- _date: string
    private string _date;
    //- _minutes: float
    protected float _minutes;
    //- _distance: float
    protected float _distance;


    //+ Activity()
    public Activity(string date, float minutes, float distance)
    {
        _date = date;
        _minutes = minutes;
        _distance = distance;
    }


    public string GetDate()
    {
        return _date;
    }

    public float GetMinutes()
    {
        return _minutes;
    }

    //+ abstract GetDistance()
    public abstract float GetDistance();
    //+ abstract GetPace()
    public abstract float GetPace();

    public abstract float GetSpeed();

    //formate 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
    //+ GetSummary()
    public string GetSummary()
    {
        string  activityName= GetType().Name;
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();

        return $"{_date} {activityName} ({_minutes} min): Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
    }

}