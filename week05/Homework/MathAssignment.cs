using System;
using System.Reflection.PortableExecutable;


public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;

    public string TextBookSection{ get{return _textbookSection;} set{_textbookSection = value;}}
    public string Problems{get{return _problems;} set{_problems = value;}}

    public MathAssignment(string textbookSection, string problems, string topic, string name): base(topic, name)
    {
        TextBookSection = textbookSection;
        Problems = problems;  
    }

    public string MathHomeWorkList()
    {
        return $"Section {TextBookSection} Problems {Problems}";
    }
}
