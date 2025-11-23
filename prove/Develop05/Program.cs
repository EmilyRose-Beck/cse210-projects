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
            Console.WriteLine($"Points: {currentPoints}");
            Console.WriteLine();

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
                    Console.WriteLine("\n~~~Your Goals~~~\n");
                    Console.WriteLine($"\nCurrent Points; {currentPoints}\n");

                    if (goals.Count == 0)
                    {
                        Console.WriteLine("You haveen't made any goals yet.");
                    }
                    else
                    {
                        for (int i = 0; i < goals.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {goals[i].GetDisplayText()}");
                        }
                    }
                    Console.WriteLine("\nPress ENTER to continue...");
                    Console.ReadLine();
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
                        if (!goals[i].IsComplete())
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

                    Console.WriteLine("\nPress ENTER to continue...");
                    Console.ReadLine();
                    break;


                case "4":
                    Console.WriteLine("\nChoose save slot:");
                    Console.WriteLine("1. Save Slot 1");
                    Console.WriteLine("2. Save Slot 2");
                    Console.WriteLine("3. Save Slot 3");
                    Console.Write("Enter option: ");
                    string saveChoice = Console.ReadLine();

                    string saveFile = saveChoice switch
                    {
                        "1" => "Save1.txt",
                        "2" => "Save2.txt",
                        "3" => "Save3.txt",
                        _ => null
                    };

                    if (saveFile == null)
                    {
                        Console.WriteLine("Invalid slot!");
                        break;
                    }

                    saver.SaveGoals(goals, currentPoints, saveFile);
                    break;


                case "5":
                    loader.DisplaySaveSlots();
                    Console.Write("\nChoose a save slot to load (1-3): ");
                    string loadChoice = Console.ReadLine();

                    string loadFile = loadChoice switch
                    {
                        "1" => "Save1.txt",
                        "2" => "Save2.txt",
                        "3" => "Save3.txt",
                        _ => null
                    };

                    if (loadFile == null)
                    {
                        Console.WriteLine("Invalid slot!");
                        break;
                    }

                    (List<Goal> goals, int points)? loadedData =

                        loader.LoadGoals(loadFile);

                    if (loadedData != null)
                    {
                        goals = loadedData.Value.goals;
                        currentPoints = loadedData.Value.points;

                        Console.WriteLine("\nSave successfully loaded!");
                    }
                    else
                    {
                        Console.WriteLine("\nUh Oh!");
                    }
                    break;


                case "6":
                    Console.WriteLine("\nChoose save slot to delete (1-3):");
                    string delChoice = Console.ReadLine();
                    int delSlot;

                    if (int.TryParse(delChoice, out delSlot) && delSlot >= 1 && delSlot <= 3)
                    {
                        string delFile = $"Save{delSlot}.txt";
                        
                        if (saver.DeleteSave(delFile))
                        {
                            Console.WriteLine($"{delFile} deleted.");

                            // RESET DATA IN MEMORY
                            goals.Clear();
                            currentPoints = 0;
                            Console.WriteLine("Local goals and points reset.");
                        }
                        else
                        {
                            Console.WriteLine("No save file found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                    }
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