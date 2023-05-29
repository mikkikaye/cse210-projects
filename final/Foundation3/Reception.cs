using System;
using System.Collections.Generic;
public class Reception : AnEvent
{
    private List<string> _attendees;
    private string _email;
    public Reception(string email, string title, string description, DateTime eventDateTime, Address address) : base(title, description, eventDateTime, address)
    {
        _attendees = new List<string>();
        _email = email;
    }
    public override string EventSpecificInformation()
    {
        return ($"RSVP to {_email}.");
    }
    public void RSVPAttendee(string newAttendee)
    {
        _attendees.Add(newAttendee);
    }
}