using System;
using System.Collections.Generic;


public class MangeScripture
//This is now a list of scriptures and a random scripture picker.

{


    //attribute
    // asks user if they want to add a new scripute to the list
    // asks if user wants to see their current memoriz list
    private List<Reference> _scriptures = new List<Reference>();
    private ScriptureList _scriptureList = new ScriptureList();
    private Reference _currentReference;
    private List<HidesWords> _words = new List<HidesWords>();
    private Random _random = new Random();



    //behavior
    // displays list of scriputes
    //saves new scripute to list
    //other classes are able to call from list 

    public MangeScripture()
    {
        _currentReference = _scriptureList.GetRandomScripture();
        string text = _currentReference.GetText();

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new HidesWords(word));
        }
    }


    /* don't need this now
        // didn't like a comma bewtwwn reference and newscripture
        public void AddScripture(Reference newScripture)
        {
            _scriptures.Add(newScripture);
        }
    */

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_currentReference.GetDisplayText());
        Console.WriteLine();

        foreach (HidesWords w in _words)
        {
            w.Display();
        }

        Console.WriteLine("\n");
    }

    public void HideRandomWords(int count)
    {
        int hidden = 0;
        while (hidden < count)
        {
            int index = _random.Next(_words.Count);
            if (_words[index].IsRevealed())
            {
                _words[index].Hide();
                hidden++;
            }

            // prevent infinite loop if all words are hidden
            if (AllHidden()) break;
        }
    }

/* i think this might be done? well see
    public Reference GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
*/
    public bool AllHidden()
    {
        foreach (HidesWords w in _words)
        {
            if (w.IsRevealed()) return false;
        }
        return true;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Press ENTER to hide words or type 'quit' to end.");

        while (true)
        {
            Display();

            Console.WriteLine("Press ENTER or type 'quit':");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            HideRandomWords(3);

            if (AllHidden())
            {
                Display();
                Console.WriteLine("All words are hidden!");
                break;
            }
        }
    }
    
    public void DisplayAllReferences()
    {
        foreach (Reference r in _scriptures)
        {
            Console.WriteLine(r.GetDisplayText());
        }
    }

}