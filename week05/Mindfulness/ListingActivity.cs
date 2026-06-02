using System;

public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;

    private List<string> _unusedPrompts;
    Random _rand = new Random();

    public int Count{get{return _count;} set{_count = value;}}
    public List<string> Prompts{get{return _prompts;} set{_prompts = value;}}
     

    public ListingActivity(): base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
    
        Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"            
        };
        _unusedPrompts = new List<string>(Prompts);
        
        
    }
    public string GetRandomPrompt()
    {
        if(_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(Prompts);
        }
        int index = _rand.Next(_unusedPrompts.Count);
        string prompts = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return prompts;
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">>>> ");
            string? response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
                Count++;
            }
        }
        return responses;
    }

    public void Run()
    {
        Count = 0;
        DisplayStartingMessage();

        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("List as many responses as you can.");
        Console.Write("You may begin in...");
        ShowCountDown(10);
        
        System.Console.WriteLine();
        GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {Count} items.");

        DisplayEndingMessage();
    }
}

