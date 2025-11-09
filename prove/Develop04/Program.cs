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
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a NUMBER from the menu: ");

            string choice = Console.ReadLine();
            int choicePicker = int.Parse(choice);

            //i wanna play with switch again
            switch (choicePicker)
            {
                case 1:
                    Breathing breathing = new Breathing();
                    breathing.RunBreathing();
                    break;

                case 2:
                    Reflecting reflecting = new Reflecting();
                    reflecting.RunReflecting();
                    break;

                case 3:
                    Listing listing = new Listing();
                    listing.RunListing();
                    break;

                case 4:
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



