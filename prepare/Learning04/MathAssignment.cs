//with this setup, MathAssignment had a red squiggle until it was used on line 9.
public class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problems;


    //stundentName and topic are pulled from Assigment, Assigment is my parent class if I did everything correctly
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    //saw it in the sample  while I was struggling, looks like the : is what causes the program to look at Assignment for studnetName and topic
    : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} and Problems {_problems}";
    }
}