using System;
using System.Collections.Generic;
public class OutdoorGathering : AnEvent
{
    private string _weather;
    public OutdoorGathering(string title, string description, DateTime eventDateTime, Address address) : base(title, description, eventDateTime, address)
    {
        WeatherGenerator newWeather = new WeatherGenerator();
        _weather = newWeather.GetRandomWeather();
    }
    public bool IsWeatherBad()
    {
        if (_weather == "thunderstorms" || _weather == "snowy" || _weather == "rainy")
        {
            return true;
        }
        return false;
    }
    public override string EventSpecificInformation()
    {
        return ($"Expected weather is {_weather}.");
    }
}