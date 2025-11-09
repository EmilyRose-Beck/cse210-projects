using System;
using System.Collections.Generic;
using System.Threading;

class Reflecting : Loading
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public Reflecting()
        : base("Reflecting",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunReflecting()
    {
        DisplayStarting();
        ShowPrompt();
        GetReady();
        Reflect();
        DisplayEnding();
    }

    protected new void GetReady()
    {
        Console.WriteLine("\nGet ready...");
        Spinner spinner = new Spinner();
        spinner.Display(3);
    }

    private void ShowPrompt()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("Prompt");
        Console.WriteLine($"\n~~~ {prompt} ~~~");
        Console.WriteLine("\nPress Enter to start.");
        Console.ReadLine();
    }  
    
    private void Reflect()
    {

        Spinner spinner = new Spinner();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        List<string> noRepeats = new List<string>(_questions);

        //&& is jsut And
        while (DateTime.Now < endTime && noRepeats.Count > 0)
        {
            int index = _random.Next(noRepeats.Count);
            string question = noRepeats[index];
            noRepeats.RemoveAt(index); // remove it so it won’t repeat

            Console.Write($"\n>>> {question} ");
            spinner.Display(2);
        }
    }
}
