using System;
using System.Collections.Generic;

class PromptGenerator
{
    //Attributes


    /*
    string promptOne = "Who was the most interesting person I interacted with today? ";
    string promptTwo = "What was the best part of my day? ";
    string promptThree = "How did I see the hand of the Lord in my life today? ";
    string promptFour = "What was the strongest emotion I felt today? ";
    string promptFive = "If I had one thing I could do over today, what would it be? ";
    */
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be?  "
    };

    private Random random = new Random();

    public string GrabPrompt()
    {
    int randomIndex = random.Next(0, prompts.Count);
    string selectedprompt = prompts[randomIndex];
    return selectedprompt;
    }
}