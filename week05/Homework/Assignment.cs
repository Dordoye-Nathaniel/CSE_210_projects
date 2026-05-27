using System;


public class Assignment
{
    private string _name;
    private string _topic;

    public string Name{get{return _name;} set{_name = value;}}
    public string Topic{get{return _topic;} set{_topic = value;}}

    public Assignment(string topic, string name)
    {
        Name = topic;
        Topic = name;
    }

    public string GetSummary()
    {
        return $"{Name} - {Topic}";
    }
}
