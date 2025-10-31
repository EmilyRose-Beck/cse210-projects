using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Marge Flower", "Muliplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Elmer Zost", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Daniel Beck", "Civial War Histroy", "The Differnt Motives");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}
// :P this one was easy but I felt odds changing names now