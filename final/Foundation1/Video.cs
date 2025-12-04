/*
Your program should have a class for a Video that has the 
responsibility to track the title, author, and length (in seconds)
 of the video. Each video also has responsibility to store a list
  of comments, and should have a method to return the number of 
  comments.
*/
using System;
using System.Globalization;
using System.Net;
using System.Reflection;

class Video
{
    // -_title: string()
    private string _title;
    // - _author: string()
    private string _author;
    // - _secondsTimed: float()
    private float _secondsTimed;
    // - _comments: List<Comment>
    private List<Comment> _comments = new List<Comment> ();
    

    //+ Video (title, author, seconds)
    //+ GetNumberOfComments()
    private int _numberOfComments;

    public void Display(string title, string author, float secondsTimed, int numberOfComments)
    {
        _title = title;
        _author = author;
        _secondsTimed = secondsTimed;
        _numberOfComments = numberOfComments;
        Console.WriteLine("testing~~~");

        foreach (string Comment in _comments)
        {
            _numberOfComments = _numberOfComments + 1;
    
        }
        Console.WriteLine($"{_numberOfComments}");
    }
    //+ AddComment()
    //+ DisplayVideo()
}