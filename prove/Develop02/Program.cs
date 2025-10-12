//menu
//I used AI to debug and try to tutor me for my "Exceed Requirements". 
//I changed so much code. It felt like pulling teeth to get it to explain the different methods.
//I regret trying to do extra I should have just turned it in. I made a whole new class because my old code refused to work.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        SaveLoad saveLoad = new SaveLoad();
        PromptGenerator promptGen = new PromptGenerator();

        bool stop = false;

        while (stop == false)
        {
            Console.WriteLine("1. Write entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("*Remember what you name your Journal when you save so you can load it later!*");
            Console.Write("> ");
            string pick = Console.ReadLine();
            pick = pick.ToLower();
            switch (pick)
            //switch aparently only works in C#10?
            {
                case "1" or "write entry" or "1. write entry":
                    string prompt = promptGen.GrabPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2" or "2. display entries" or "display entries":
                    bool displayMenuActive = true;
                    while (displayMenuActive)
                    {
                        Console.WriteLine("------");
                        Console.WriteLine("1. Display ALL entries");
                        Console.WriteLine("2. Display entries for a specific date");
                        Console.WriteLine("3. Return to main menu");
                        Console.WriteLine("Only enter 1, 2, or 3");
                        Console.Write("> ");
                        string displayChoice = Console.ReadLine();

                        switch (displayChoice)
                        {
                            case "1":
                                journal.DisplayAllEntries();
                                break;

                            case "2":
                                Console.Write("Desired date (e.g., 1999-01-25): ");
                                string dateInput = Console.ReadLine();
                                DateTime chosenDate;
                                if (DateTime.TryParse(dateInput, out chosenDate))
                                {
                                    journal.DisplayEntriesForDate(chosenDate);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.\n");
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid option. Please try again.\n");
                                break;
                        }
                    }
                    break;

                case "3" or "3. save journal" or "save journal":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    saveLoad.SaveJournal(saveFile, journal.Entries);
                    Console.WriteLine("Journal saved.\n");
                    break;

                case "4" or "4. load journal" or "load journal":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    List<Entry> loadedEntries = saveLoad.LoadJournal(loadFile);
                    journal.Entries = loadedEntries;
                    Console.WriteLine("Journal loaded.\n");
                    break;

                case "5" or "5. quit" or "quit":
                    stop = true;
                    break;

            }
        }
    }
}