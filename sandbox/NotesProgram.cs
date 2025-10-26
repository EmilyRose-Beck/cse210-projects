using System;

class NotesProgram
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Word Word1 = new Word("Jesus");
        Word Word2 = new Word("wept.");
        Word1.Display();
        Word2.Display();
        Word2.Hide();
        Word1.Display();
        Word2.Display();
    }
}