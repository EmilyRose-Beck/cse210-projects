using System;

public class Lecture : Event
{
    // -_speaker: string
    private string _speaker;
    // -_maxCap: int
    private int _maxCap;

    public Lecture(string eventTitle, string description, string date, string time, Address address, string eventType, string speficDetails, string speaker, int maxCap)
        : base(eventTitle, description, date, time, address, eventType, speficDetails)
    {
        _speaker = speaker;
        _maxCap = maxCap;
    }

/*Standard details - Lists the title, description, date, time, and address.*/

    // + GetStandardDetails()
  public new string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }

   /* Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.*/

    // + GetFullDetails()
    public new string GetFullDetails()
    {
        return base.GetFullDetails() +
            $"\nSpeaker: {_speaker}\n" +
            $"Max Capacity: {_maxCap}";
    }

    /*Short description - Lists the type of event, title, and the date.*/

    // + GetShortDetails()
    public new string GetShortDetails()
    {
        return $"Lecture: {GrabEventTitle()} on {GrabDate()}";
    }
}