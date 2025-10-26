using System;
using System.Collections.Generic;


public class MangeScripture
//This is now a list of scriptures and a random scripture picker.

{


    //attribute
    // asks user if they want to add a new scripute to the list
    // asks if user wants to see their current memoriz list
    private List<Reference> _scriptures = new List<Reference>();
    private Random _random = new Random();



    //behavior
    // displays list of scriputes
    //saves new scripute to list
    //other classes are able to call from list 

    // didn't like a comma bewtwwn reference and newscripture
    public void AddScripture(Reference newScripture)
    {
        _scriptures.Add(newScripture);
    }

    public Reference GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    public void DisplayAllReferences()
    {
        foreach (Reference r in _scriptures)
        {
            Console.WriteLine(r.GetDisplayText());
        }
    }

}