using System;

class Reception : Event
{

// -_isRsvpe: bool
    private bool _isRsvpe;

    public Reception(string eventTitle, string description, string date, string time, Address address, string eventType, string speficDetails, bool isRsvpe)
        : base(eventTitle, description, date, time, address, eventType, speficDetails)
    {
        _isRsvpe = isRsvpe;
    }

// + GetStandardDetails()
// + GetFullDetails()
// + GetShortDetails()
}