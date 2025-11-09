using System;

class Loading
{
    private string _activityName;
    private string _description;
    protected int _duration;

    protected Spinner _spinner = new Spinner();
    protected Countup _countup = new Countup();
    protected Countdown _countdown = new Countdown();
    private Random _random = new Random();

    public Loading(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    protected void AnimationPicker(int seconds = -1)
    {
        int duration = (seconds == -1) ? _duration : seconds;

        int choice = _random.Next(1, 4); // 1–3 inclusive

        switch (choice)
        {
            case 1:
               // Console.WriteLine("(Using Spinner)");
                _spinner.Display(duration);
                break;

            case 2:
                //Console.WriteLine("(Using Count Up)");
                Countup.RunCountup(duration);
                break;

            case 3:
               // Console.WriteLine("(Using Count Down)");
                Countdown.RunCountDown(duration);
                break;
        }
    }

    protected void DisplayStarting()
    {
        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"     {_activityName} Activity");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(_description);
        Console.WriteLine();
        _duration = GetDuration();
    }

    protected void DisplayEnding()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"\nYou have completed the {_activityName} activity for {_duration} seconds.");
    }

    protected int GetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    protected void GetReady()
    {
        Console.WriteLine("\nGet ready...");
        AnimationPicker();
    }
}
