public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public string ToSave()
    {
        return $"{Date:yyyy-MM-dd}~{Prompt}~{Response}";
    }
}
