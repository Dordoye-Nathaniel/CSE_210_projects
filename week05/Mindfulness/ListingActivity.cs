using System;

public class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;
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
    }

    public string GetRandomPrompt()
    {
        int index = _rand.Next(Prompts.Count);
        return Prompts[index];
    }

    public List<string> GetListFromUSer()
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
        DisplayStartingMessage();

        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("List as many responses as you can.");
        Console.Write("You may begin in...");
        ShowCountDown(10);
        
        System.Console.WriteLine();
        List<string> responses = GetListFromUSer();

        Console.WriteLine();
        Console.WriteLine($"You listed {Count} items.");

        DisplayEndingMessage();
    }
}

