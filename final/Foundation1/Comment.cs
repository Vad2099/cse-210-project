using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Comment
{
    private string _personName;
    private string _comment;

    public Comment(string personName, string comment)
    {
        _personName = personName;
        _comment = comment;
    }

    public string GetPersonName()
    {
        return _personName;
    }

    public void SetPersonName(string personName)
    {
        _personName = personName;
    }

    public string GetComment()
    {
        return _comment;
    }

    public void SetComment(string comment)
    {
        _comment = comment;
    }

    


}