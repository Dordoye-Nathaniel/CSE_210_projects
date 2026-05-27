using System;
using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    List<Comment> _comments;

    public string Title
    {
        get{return _title;}
        set{_title = value;}
    }

    public string Author
    {
        get{return _author;}
        set{_author = value;}
    }
    public int Lenght
    {
        get{return _lenght;}
        set{_lenght = value;}
    }

    public Video(string title, string author, int lenght)
    {
        Title = title;
        Author = author;
        Lenght = lenght;
        _comments = new List<Comment>();
    }

    public void AddComennt(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayComment()
    {
        foreach(var c in _comments)
        {
            System.Console.WriteLine($"{c.Name}: {c.Text}");
        }
    }
    
}