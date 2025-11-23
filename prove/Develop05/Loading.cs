using System;


public class Loading
{
    private readonly List<string> _validFiles = new List<string>
{
    "Save1.txt",
    "Save2.txt",
    "Save3.txt"
};

    // Shows which save slots are empty or in use with last saved time
    public void DisplaySaveSlots()
    {
        Console.WriteLine("Select a Save Slot:\n");

        foreach (string fileName in _validFiles)
        {
            if (File.Exists(fileName))
            //checks if file exsits and adds date
            {
                DateTime lastModified = File.GetLastWriteTime(fileName);
                Console.WriteLine($"{fileName.Replace(".txt", "")} — Last Saved: {lastModified:MMM dd, yyyy}");
            }
            else //if file doesn't exsist
            {
                Console.WriteLine($"{fileName.Replace(".txt", "")} — Empty");
            }
        }
    }

    
    // Returns loaded goals and currentPoints
    // Returns null if load fails
    public (List<Goal> goals, int points)? LoadGoals(string fileName)
    {
        //validates
        if (!_validFiles.Contains(fileName))
        {
            Console.WriteLine("\nInvalid file name!");
            return null;
        }

        // Check if file exists
        if (!File.Exists(fileName))
        {
            Console.WriteLine("\nNo save file found for that slot!");
            return null;
        }

         try
        {
            List<Goal> loadedGoals = new List<Goal>();
            int loadedPoints = 0;

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                if (line.StartsWith("Points:"))
                {
                    // Format: Points: 2000
                    loadedPoints = int.Parse(line.Split(": ")[1]);
                }
                else
                {
                    // Goal line → Convert to correct object type later
                    Goal goal = ParseGoal(line);
                    if (goal == null)
                    {
                        Console.WriteLine("\n ERROR LOADING: Corrupted goal data!");
                        Console.WriteLine("Please delete this save and try again.");
                        return null;
                    }
                    loadedGoals.Add(goal);                
                }
            }

            Console.WriteLine($"\nLoaded {loadedGoals.Count} goals and {loadedPoints} points!");
            return (loadedGoals, loadedPoints);
        }
        catch
        {
            Console.WriteLine("\n ERROR LOADING FILE: Save data unreadable!");
            Console.WriteLine("Please delete the file and create a new save.");
            return null;
        }
    }

    // Helper for turning strings back into Goal objects
    private Goal ParseGoal(string data)
    {
        string[] parts = data.Split('|');

        // parts[0] tells us the type:
        // Simple Goal
        // Eternal Goal
        // Checklist Goal
        string goalType = parts[0];

        if (goalType == "Simple Goal" && parts.Length == 5)
        {
            SimpleGoal g = new SimpleGoal();
            g.LoadData(parts);
            return g;
        }
        if (goalType == "Enternal Goal" && parts.Length == 4) 
        {
            EnternalGoal g = new EnternalGoal();
            g.LoadData(parts);
            return g;
        }
        if (goalType == "Checklist Goal" && parts.Length == 7)
        {
            ChecklistGoal g = new ChecklistGoal();
            g.LoadData(parts);
            return g;
        }

        return null; // Corrupted data
    }
}