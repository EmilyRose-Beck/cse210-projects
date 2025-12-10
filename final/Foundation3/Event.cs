using System;
using System.Net.Sockets;

public class Event
{
    // -_eventTitle: string
    private string _eventTitle;
    // -_description: string
    private string _description;
    // -_date: string
    private string _date;
    // -_time: string
    private string _time;
    // -_address: Address
    private Address _address;

    private string _eventType;

/*
information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
*/
    private string _speficDetails;

    public Event(string eventTitle, string description, string date, string time, Address address, string eventType, string speficDetails)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
        _speficDetails = speficDetails;

    }

    //gets just incase
    public string GrabEventTitle()
    {
        return _eventTitle;
    }

    public string GrabDescription()
    {
        return _description;
    }

    public string GrabDate()
    {
        return _date;
    }

    public string GrabTime()
    {
        return _time;
    }



/*Standard details - Lists the title, description, date, time, and address.*/
    // + GetStandardDetails()

    public string GetStandardDetails()
    {
        return _eventTitle + _description + _date + _time + _address;
    }

   /* Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.*/
    // + GetFullDetails()
    public string GetFullDetails()
    {
        return _eventTitle + _description + _date + _time + _address + _eventType + _speficDetails;
    }    

    
/*Short description - Lists the type of event, title, and the date.*/
    // + GetShortDetails()
    public string GetShortDetails()
    {
        return _eventType + _eventTitle + _date;
    }
}