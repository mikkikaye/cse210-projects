using System;

public class Comment
{
    private string _commentor;
    private string _commentText;

    public Comment(string commentor, string commentText)
    {
        _commentor = commentor;
        _commentText = commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_commentor}: {_commentText}");
    }
}