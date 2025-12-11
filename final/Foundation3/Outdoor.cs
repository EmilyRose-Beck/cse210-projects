using System;
using System.Collections.Generic;

public class Outdoor : Event
{
    
// - _weather: string
    private string _weather;
    private List<string> _weatherOptions = new List<string>
    {
        "Sunny",
        "Cloudy",
        "Windy",
        "Light Rain",
        "Heavy Rain",
        "Snow",
        "Hot and Dry",
        "Cool Breeze",
        "Thunderstorms"
    };

    private string _randomWeather;

    public Outdoor(string eventTitle, string description, string date, string time, Address address, string eventType, string speficDetails, string weather)
        : base(eventTitle, description, date, time, address, eventType, speficDetails)
    {
        _weather = weather;

        Random random = new Random();
        _randomWeather = _weatherOptions[random.Next(_weatherOptions.Count)];
    }

// + GetStandardDetails()
    public string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }
// + GetFullDetails()
    public string GetFullDetails()
    {
        return base.GetFullDetails() + 
            $"\nWeather: {_weather}" +
            $"\nCurrent Weather Prodition: {_randomWeather}";

    }
// + GetShortDetails()
    public string GetShortDetails()
    {
        return $"Outdoor Event: {GrabEventTitle()} on {GrabDate()}";
    }
}