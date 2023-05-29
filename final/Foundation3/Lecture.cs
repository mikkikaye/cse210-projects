using System;
using System.Collections.Generic;
public class Lecture : AnEvent
{
    private string _speaker;
    private int _capacityLeft;
    private int _capacity;

    public Lecture(string speaker, int capacity, string title, string description, DateTime eventDateTime, Address address) : base(title, description, eventDateTime, address)
    {
        _speaker = speaker;
        _capacityLeft = capacity;
        _capacity = capacity;
    }
    public bool AtCapacity()
    {
        if (_capacityLeft == 0)
        {
            return true;
        }
        return false;
    }
    public int AdmitOne()
    {
        _capacityLeft = _capacityLeft - 1;
        return _capacityLeft;
    }
    public override string EventSpecificInformation()
    {
        return ($"The lecture will be given by {_speaker}. There will be a maximum of {_capacity} ");
    }

}