//started with looking at one of my older projects and changed it to fit my cuuent needs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int currentPoints = 0;

        Saving saver = new Saving();
        Loading loader = new Loading();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Goal Tracker Menu ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Delete Save");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nChoose goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Enternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Enter choice: ");
                    string typeChoice = Console.ReadLine();

                        //I can shorten it!!! Did everyone one else know this?!
                    Goal newGoal = typeChoice switch
                    {
                        "1" => new SimpleGoal(),
                        "2" => new EnternalGoal(),
                        "3" => new ChecklistGoal(),
                        _ => null
                    };

                    if (newGoal == null)
                    {
                        Console.WriteLine("Invalid.");
                    }
                    else
                    {
                        newGoal.CreateGoal();
                        goals.Add(newGoal);
                        Console.WriteLine("New Goal made.");
                    }

                    break;

                case "2":
                    Console.WriteLine($"\nCurrent Points; {currentPoints}\n");

                    if (goals.Count == 0)
                    {
                        Console.WriteLine("You haveen't made any goals yet.");
                    }
                    else
                    {
                        Console.WriteLine("Your Goals:");
                        for (int i = 0; i < goals.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {goals[i].GetDisplayText()}");
                        }
                    }
                    break;

                case "3":
                    if (goals.Count == 0)
                    {
                        Console.WriteLine("Nothing to record.");
                        break;
                    }

                    Console.WriteLine("\nChoose a goal to record:");
                    List<int> activeIndexes = new List<int>();

                    for (int i = 0; i < goals.Count; i++)
                    {
                        if (!goals[i].IsComplete())  // only show incomplete goals
                        {
                            activeIndexes.Add(i);
                            Console.WriteLine($"{activeIndexes.Count}. {goals[i].GetDisplayText()}");
                        }
                    }

                    if (activeIndexes.Count == 0)
                    {
                        Console.WriteLine("All goals are complete — nothing to record!");
                        break;
                    }

                    Console.Write("Enter number: ");
                    int goalIndex;
                    if (int.TryParse(Console.ReadLine(), out goalIndex)
                        && goalIndex >= 1
                        && goalIndex <= activeIndexes.Count)
                    {
                        Goal selected = goals[activeIndexes[goalIndex - 1]];
                        int earned = selected.RecordEvent();
                        currentPoints += earned;

                        Console.WriteLine($"You earned {earned} points!");
                        Console.WriteLine($"Total Points: {currentPoints}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                    break;


                case "4":
                    Console.WriteLine("\nWhich save file? (Save1.txt / Save2.txt / Save3.txt)");
                    string saveFile = Console.ReadLine();
                    saver.SaveGoals(goals, currentPoints, saveFile);
                    break;

                case "5":
                    loader.DisplaySaveSlots();
                    Console.WriteLine("\nLoad which file?");
                    string loadFile = Console.ReadLine();

                     (List<Goal> goalsLoaded, int pointsLoaded)? loadedData = loader.LoadGoals(loadFile);
                    if (loadedData != null)
                    {
                        goals = loadedData.Value.goalsLoaded;
                        currentPoints = loadedData.Value.pointsLoaded;
                        Console.WriteLine("\nSave successfully loaded!");
                    }
                    else
                    {
                        Console.WriteLine("\nUh Oh!");
                    }
                    break;

                case "6":
                    Console.WriteLine("\nWhich save to delete? (Save1.txt / Save2.txt / Save3.txt)");
                    string delFile = Console.ReadLine();
                    saver.DeleteSave(delFile);
                    break;

                case "7":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}