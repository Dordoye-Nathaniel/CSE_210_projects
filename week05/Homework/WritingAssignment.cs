using System;

public class WritingAssignment: Assignment
{
    private string _title;
    public string Title{ get{return _title;} set{_title = value;}}

    public WritingAssignment(string title, string name, string topic):base(name, topic)
    {
        Title = title;
    }

    public string GetWritingInformation()
    {
        return $"{Title} by {Name}";
    }
}