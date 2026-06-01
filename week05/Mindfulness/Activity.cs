using System;

public class Activity
{
    private string _programName;
    private int _duration;
    private string _programDescription;


    public string ProgramName{get{return _programName;} set{_programName = value;}}
    public int Duration{get{return _duration;} set{_duration = value;}}
    public string ProgramDescription{get{return _programDescription;} set{_programDescription = value;}}

    public Activity(string programName, string programeDescription)
    {
        ProgramName = programName;
        ProgramDescription = programeDescription;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        System.Console.WriteLine($"Welcome to {ProgramName}.");
        System.Console.WriteLine();
        System.Console.WriteLine(ProgramDescription);
        System.Console.WriteLine();

        System.Console.Write("How long, in seconds, would you want the programme to run? ");
        Duration = int.Parse(Console.ReadLine()!);

        Console.Clear();
        System.Console.WriteLine("Get ready...");
        ShowSpinner(4);
    }

    public void DisplayEndingMessage()
    {
        System.Console.WriteLine("Well done!");
        ShowSpinner(4);

        System.Console.WriteLine($"You have completed {Duration} seconds of the {ProgramName}.");
        ShowSpinner(4);
    } 

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>{"/","-", "|", "+"};

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            Console.Write(animation[i]);
            Thread.Sleep(100);
            Console.Write("\b \b"); 

            i++;

            if(i >= animation.Count)
            {
                i = 0;
            }           
        }
        System.Console.WriteLine();
        
    }

    public void ShowCountDown(int seconds)
    {

        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            for(int j = 0; j<i.ToString().Length; j++)
            {
                Console.Write("\b \b");
            }
        }  
    }

    
}