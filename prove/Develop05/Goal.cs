/*
I would like to cretid my parnter https://chatgpt.com/g/g-sQydCh2Q6-pythonista
who kept saying my code was wrong and kept being right about it. I hate you
and thank you for your help you crummy potateo.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        bool stop = false;

        while (!stop)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Add Simple Goal");
            Console.WriteLine("2. Enternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Point Shop");
            Console.WriteLine("5. Point History");
            Console.WriteLine("6. Goal History");
            Console.WriteLine("7. Quit");
            Console.Write("Select a NUMBER from the menu: ");

            string choice = Console.ReadLine();
            int choicePicker = int.Parse(choice);

            //i wanna play with switch again
            switch (choicePicker)
            {
                case 1:
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.RunSimpleGoal();
                    break;

                case 2:
                    EnternalGoal enternalGoal = new EnternalGoal();
                    enternalGoal.RunEnternalGoal();
                    break;

                case 3:
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.RunChecklistGoal();
                    break;

                case 4:
                    PointShop pointShop = new PointShop();
                    pointShop.RunPointShop();
                    break;

                //tracts purpaches from shop and overall total of points even from deleted goals
                case 5:
                    PointHistory pointHistory = new PointHistory();
                    pointHistory.RunPointHistory();
                    break;

                //can delete old goals so they are no longer shown, ask if user is sure when deleting an incomplet checklist, Enternal, or an incomplete simple goal
                case 6:
                    GoalHistory goalHistory = new GoalHistory():


                case 7:
                    stop = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1–4.");
                    break;
            }
            if (!stop)
            {
                Console.WriteLine("\nOh! Hi! Press Enter to return to Menu.");
                Console.ReadLine();
            }
        }
    }
}



