//going to use the same names as the sample to help me compare my work but trying without looking otherwise
// I supsect this to be similar to the Math Class

public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) //forgot base, but I remembered it by looking at MathAssignment
    {
        _title = title;
    }
    
    public string GetWritingInfo()
    {
        //forgot I named mine grab vs get spent too long trying to figure out what was wrong as I kept reading them both as grab
        string studentName = GrabStudentName();

        return $"{_title} by {studentName}";
    }    
    
}
