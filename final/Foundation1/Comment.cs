/*
A comment should be defined by the Comment class which
   has the responsibility for tracking both the name of the person
    who made the comment and the text of the comment.
*/

using System;

class Comment
{
    // - _commentText: string()
    private string _commentText;
    // - _commentersName: string()
    private string _commentersName;

    // + Comment ()
    public Comment(string commentersName, string commentText)
    {
        _commentersName = commentersName;
        _commentText = commentText;
    }
    // + GetCommenterName()
    public string GetCommenterName()
    {
        return _commentersName;
    }

    // + GetCommentText()
    public string GetCommentText()
    {
        return _commentText;
    }
    // + DisplayComments()
    public void DisplayComment()
    {
        Console.WriteLine($"{_commentersName}: {_commentText}");
    }
}