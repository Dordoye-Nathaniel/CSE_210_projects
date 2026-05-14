using System;


public class Job
{
    // Attributes of the Job class
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        // Display the attributes of the Job class
        System.Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
