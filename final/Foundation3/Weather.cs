using System;
using System.Collections.Generic;

public class WeatherGenerator
{
    private List<string> _weatherTypes;
    
    public WeatherGenerator()
    {
        _weatherTypes = new List<string>{"sunny", "rainy", "cloudy", "partly cloudy", "thunderstorms", "snowy", "foggy", "windy"};
    }
    public string GetRandomWeather()
    {
        Random random = new Random();
        int numberWeather = random.Next(_weatherTypes.Count);
        string randomWeather = _weatherTypes[numberWeather];
        return randomWeather;
    }
}