using System.Net.NetworkInformation;

public class Assignment
{
    //Note I still need help from the sample before things click in my brain
    //do more pracitce with coding in C# after I finish this week's project.
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // tried this without looking at the sample
    //this lets me us _studentName since its private in other classes
    public string GrabStudentName()
    {
        return _studentName;
    }
    //lets me use _topic in other classes
    public string GrabTopic()
    {
        return _topic;
    }
    //looked at sample to find why it wasn't working in forgot a ; on line 25. Well tyniclly i didn't forget it, but it was a : instead oops

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}