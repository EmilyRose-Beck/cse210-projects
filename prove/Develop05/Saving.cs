using System.Security.Cryptography.X509Certificates;

public class Saving
{
    // This prevents the value from being changed later in the program.
    //readonly is used for 'creation date' so it always stays accurate
    // and cannot be accidentally modified.
    //it seemed intresting and i wanted to see how it worked compared to const or static
    private readonly List<string> _validFiles = new List<string> 
    {
        "Save1.txt",
        "Save2.txt",
        "Save3.txt"
    };

    public void SaveGoals(List<Goal> goals, int currentPoints, string fileName)
    {
        if (!_validFiles.Contains(fileName))
        {
            Console.WriteLine("Invalid name, please check that you properly typed the name");
            return;
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.SaveFormat());
            }
            outputFile.WriteLine($"Points: {currentPoints}");
        }
        Console.WriteLine($"Saved to {fileName}!");
    }
    //deletes old saves (file)
    public void DeleteSave(string fileName)
    {
        //checks if its a valid filename
        if (!_validFiles.Contains(fileName))
        {
            Console.WriteLine("\nInvalid file name!");
            return;
        }

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine($"Deleted {fileName}.");
        }
        else //checks if the file does exist to delete
        {
            Console.WriteLine($"No save file found.");
        }
    }
    
}
