using System;
using System.IO;
using System.Collections.Generic;

class SaveLoad
{
    // Save all entries to file (creates file if it doesn't exist)
    public void SaveJournal(string filename, List<Entry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToSave());
            }
        }
    }

    // Load all entries from file, or create empty if file not exist
    public List<Entry> LoadJournal(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                loadedEntries.Add(FromLoad(line));
            }
        }
        // If the file does not exist, just return the empty list
        return loadedEntries;
    }

    public Entry FromLoad(string savedString)
    {
        string[] parts = savedString.Split('~');
        Entry entry = new Entry();
        entry.Date = DateTime.Parse(parts[0]);
        entry.Prompt = parts[1];
        entry.Response = parts[2];
        return entry;
    }
}
