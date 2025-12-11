using System;
using System.Collections.Generic;

public class Outdoor : Event
{
    
// - _weather: string
    private string _weather; //required
    private string _weatherPrediction; //prediction

    public Outdoor(string eventTitle, string description, string date, string time, Address address, string eventType, string speficDetails, string weather, string weatherPrediction)
        : base(eventTitle, description, date, time, address, eventType, speficDetails)
    {
        _weather = weather;
        _weatherPrediction = weatherPrediction;

    }

// + GetStandardDetails()
    public new string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }
// + GetFullDetails()
    public new string GetFullDetails()
    {
        return base.GetFullDetails() + 
            $"\nWeather Requirment: {_weather}" +
            $"\nWeather Prediction: {_weatherPrediction}";

    }
// + GetShortDetails()
    public new string GetShortDetails()
    {
        return $"Outdoor Event: {GrabEventTitle()} on {GrabDate()}";
    }
}