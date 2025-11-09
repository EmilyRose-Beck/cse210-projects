using System;
using System.Collections.Generic;
using System.Threading;

class Listing : Loading
{
    private List<string> _prompts;
    private Random _random = new Random();

    public Listing()
        : base("Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunListing()
    {
        DisplayStarting();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("\nStart listing! (Press Enter after each item.)\n");
        Console.Write("> ");
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> responses = new List<string>();
        string currentInput = "";

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.Enter)
                {
                    if (!string.IsNullOrWhiteSpace(currentInput))
                    {
                        responses.Add(currentInput.Trim());
                        currentInput = "";
                        Console.WriteLine();
                        Console.Write("> ");
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (currentInput.Length > 0)
                    {
                        currentInput = currentInput.Substring(0, currentInput.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    currentInput += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }

            Thread.Sleep(50); // Prevents CPU overuse
        }

        Console.WriteLine("\n\nTime’s up!");
        Console.WriteLine($"You listed {responses.Count} items.\n");

        DisplayEnding();
    }
}