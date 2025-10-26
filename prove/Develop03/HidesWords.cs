using System;
using System.Collections.Generic;

class HidesWords

{

    //attributes
    //turn verse into usable word index
    //makes a list of word that are hidden

    private string _word;
    private bool _revaeled;


    /*
    string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split(",");

        string firstName = parts[0];
        string lastName = parts[1];
    }
    */


    //behavors
    //picks a word
    //hides the pickes word
    //displays current verse

    public HidesWords(string ____)
    {
        _word = ____;
        _revaeled = true;
    }

    public void Display()
    {
        if (_revaeled)
        {
            Console.Write(" " + _word);
        }
        else
        {
            Console.Write(" ");
            //Console.Write(" " + "____");
            int size = _word.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write("_");

            }
        }

    }

    public void Hide()
    {
        _revaeled = false;
    }

    public bool IsRevealed()
    {
        return _revaeled;
    }
}