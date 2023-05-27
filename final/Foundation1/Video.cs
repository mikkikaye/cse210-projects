using System;
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public int CommentCount()
    {
        int comCount = _comments.Count;
        return comCount;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public void DisplayCommentCount()
    {
        int comCount = CommentCount();
        Console.WriteLine($"The number of comments this video has is {comCount}.");
    }
    public void DisplayVideo()
    {
        Console.WriteLine();
        Console.WriteLine($"{_title} by {_author}, {_length} seconds long");
        Console.WriteLine();
        DisplayCommentCount();
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}