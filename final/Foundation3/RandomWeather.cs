using System;
    public class RandomWeather
{
    private Random _rand = new Random();

    private List<string> _weatherOptions = new List<string>()
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

    public string GetWeather()
    {
        int index = _rand.Next(_weatherOptions.Count);
        return _weatherOptions[index];
    }
}
