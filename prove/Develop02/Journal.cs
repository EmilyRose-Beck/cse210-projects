using System;
using System.Data;
using System.Collections.Generic;

public class Journal
{
  /*
  Notes for datetime:
    DateTime specificDate = new DateTime(2023, 10, 27, 14, 30, 0);
    string customFormat = specificDate.ToString("yyyy-MM-dd HH:mm:ss"); // Output: "2023-10-27 14:30:00"
    string shortDate = specificDate.ToString("dd/MM/yyyy"); // Output: "27/10/2023"
  */

  public DateTime currentDateTime = DateTime.Now;

  //This is shorthand for creating a property that can be read (get) and written (set). C# automatically creates a hidden private field to store the data.
  
  public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entries.Add(new Entry
        {
            Date = DateTime.Now,
            Prompt = prompt,
            Response = response
        });
    }

  public void DisplayAllEntries()
  {
    foreach (var entry in Entries)
    {
      Console.WriteLine($"{entry.Date:d} - {entry.Prompt}\n{entry.Response}\n");
    }
  }
    public void DisplayEntriesForDate(DateTime date)
{
    bool found = false;

    foreach (Entry entry in Entries)
    {
        if (entry.Date.Date == date.Date)
        {
            Console.WriteLine($"{entry.Date:d} - {entry.Prompt}\n{entry.Response}\n");
            found = true;
        }
    }

    if (!found)
    {
        Console.WriteLine($"No entries found for {date:d}.\n");
    }
}

}

