using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<AnEvent> marketing = new List<AnEvent>();
        OutdoorGathering concert = new OutdoorGathering("Dierks Bentley Concert", "Fun country music concert by Dierks Bentley!", new DateTime(2023, 10, 25, 07, 30, 00), new Address("1050 State Street", "Orem", "UT"));
        marketing.Add(concert);
        
        List<string> _attendees = new List<string>{"Bob", "Sally", "Trisha", "John", "Tyler", "Mckenzie", "Kimberly", "Roger"};

        
        Reception wedding = new Reception("event@receptions.com", "Roberts' Wedding", "Come celebrate the Roberts' wedding aboard their ship!", new DateTime(2023, 06, 27, 10, 30, 00), new Address("300 State Street", "Orem", "UT"));
        foreach (string attendee in _attendees)
        {
            wedding.RSVPAttendee(attendee);
        }
        marketing.Add(wedding);

        Lecture historicalObjects = new Lecture("Dr. Indiana Jones", 1000, "Dr. Indiana Jones presents 'Finding Historical Objects'", "Learn how Dr. Jones discovered all these artifacts!", new DateTime(2023, 04, 01, 12, 30, 00), new Address("16 State Street", "Orem", "UT"));
        marketing.Add(historicalObjects);
    
        foreach (AnEvent myEvent in marketing)
        {
            Console.WriteLine($"{myEvent.ProduceShortDesc()}\n");
            Console.WriteLine($"{myEvent.ProduceFullDesc()}\n");
            Console.WriteLine($"{myEvent.ProduceStandardDesc()}\n");
        }
    }
}