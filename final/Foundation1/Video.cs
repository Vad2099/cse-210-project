using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLenght()
    {
        return _length;
    }

    public void SetLenght(int length)
    {
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    
    public List<Comment> Comments
    {
        get { return _comments; }
    }

}