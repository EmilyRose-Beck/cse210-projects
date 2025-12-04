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
    

    //+ GetNumberOfComments()
    //private int _numberOfComments;
    //using count now not needed or at least it shouldn't be needed

//+ Video (title, author, seconds)
    public Video(string title, string author, float secondsTimed)
    {
        _title = title;
        _author = author;
        _secondsTimed = secondsTimed;
    }
    //+ AddComment()
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

      //+ GetNumberOfComments()
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    //+ DisplayVideo()
    public void DisplayVideo()
    {   Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_secondsTimed} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");


        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        
        Console.WriteLine();
    }
}