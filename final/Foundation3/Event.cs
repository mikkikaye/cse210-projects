using System;
using System.Collections.Generic;
public class AnEvent
{
    protected string _title;
    protected DateTime _eventDateTime;
    protected Address _address;
    protected string _description;
    protected string _eventType;
    public AnEvent(string title, string description, DateTime eventDateTime, Address address)
    {
        _title = title;
        _description = description;
        _eventDateTime = eventDateTime; 
        _address = address;  
        if (this.GetType().Name == "OutdoorGathering")
        {
            _eventType = "Outdoor Gathering"; 
        }
        else
        {
            _eventType = this.GetType().Name;
        }
    }
    public string ProduceShortDesc()
    {
        return ($"{_eventType}: {_title}\n{_eventDateTime}");
    }
    public string ProduceFullDesc()
    {
        string fullDescription = ProduceStandardDesc() + $"\n{_eventType}\n" + this.EventSpecificInformation();
        
        return fullDescription;
    }
    public string ProduceStandardDesc()
    {
        return ($"{_title}\n{_description}\n{_eventDateTime}\nLocated at:\n{_address.DisplayAddress()}");
    }
    public virtual string EventSpecificInformation()
    {
        return "";
    }
}