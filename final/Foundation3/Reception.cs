using System;

public class Reception : Event
{

// -_isRsvpe: bool
    private bool _isRsvpe;

    public Reception(string eventTitle, string description, string date, string time, Address address, string eventType, string speficDetails, bool isRsvpe)
        : base(eventTitle, description, date, time, address, eventType, speficDetails)
    {
        _isRsvpe = isRsvpe;
    }

// + GetStandardDetails()
    public new string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }
// + GetFullDetails()
    public new string GetFullDetails()
    {
        return base.GetFullDetails() + 
            $"\nRSVP Required: {_isRsvpe}";
    }
// + GetShortDetails()
    public new string GetShortDetails()
    {
        return $"Reception: {GrabEventTitle()} on {GrabDate()}";
    }
}