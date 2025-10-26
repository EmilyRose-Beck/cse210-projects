using System;
using System.Collections.Generic;

class HidesWords

{

    //attributes
    //turn verse into usable word index
    //makes a list of word that are hidden

    private string _word;
    private bool _revealed;


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

    public HidesWords(string word)
    {
        _word = word;
        _revealed = true;
    }

        public void Hide()
    {
        _revealed = false;
    }

    public bool IsRevealed()
    {
        return _revealed;
    }
    public void Display()
    {
        if (_revealed)
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

}