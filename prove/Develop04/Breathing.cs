using System;
using System.Threading;

class Breathing : Loading
{
    public Breathing()
        : base("Breathing",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunBreathing()
    {
        DisplayStarting();
        Console.WriteLine("\nStarting breathing session...\n");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int inSeconds = 5;
        int outSeconds = 5;

        int animationChoice = new Random().Next(1, 4);

        while (DateTime.Now < endTime)
        {
            // split total time evenly for inhale/exhale phases
            // int remaining = (int)(endTime - DateTime.Now).TotalSeconds;
            // int cycleTime = Math.Max(2, remaining / 2);

            Console.Write("Breathe in...");
            Console.WriteLine();
            RunAnimation(animationChoice, inSeconds);
            Console.WriteLine();

            if (DateTime.Now >= endTime) break;

            Console.Write("Breathe out...");
            Console.WriteLine();
            RunAnimation(animationChoice, outSeconds);
            Console.WriteLine();
        }

        DisplayEnding();
    }
    
    private void RunAnimation(int choice, int seconds)
    {
        switch (choice)
        {
            case 1:
                _spinner.Display(seconds);
                break;
            case 2:
                Countup.RunCountup(seconds);
                break;
            case 3:
                Countdown.RunCountDown(seconds);
                break;
        }
    }
}
