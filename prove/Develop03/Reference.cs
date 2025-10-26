using System;
using System.Collections.Generic;


public class Reference
{
    //NOTE endverse = 0 to start

    //attributes
    //-book: string
    //-_chapter: int
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _text;

    public Reference(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _text = text;
    }

    // Getters
    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    public string GetText()
    {
        return _text;
    }

    //do I still want to seperate the verses?
    //-_beginningverse: int
    //-_endverse: int

    //behavoirs
    // Setters (if needed)
    public void SetBook(string book)
    {
        _book = book;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    // Helper method for display
    public string GetDisplayText()
    {
        if (_endVerse == 0 || _endVerse == _startVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}
