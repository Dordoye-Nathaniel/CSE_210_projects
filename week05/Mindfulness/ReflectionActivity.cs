using System;

public class ReflectionActivity: Activity
{
    private List<string> _prompts;

    private List<string> _questions;
    Random rand = new Random();


    public List<string> Prompts {get{return _prompts;} set{_prompts = value;}}
    public List<string> Questions{get{return _questions;} set{_questions = value;}}

    public ReflectionActivity(): base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        Prompts = new List<string>
        {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."            
        };
        Questions = new List<string>
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"            
        };
    }

    public string GetRandomPrompt()
    {
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        
        int index = rand.Next(_questions.Count);
        return _questions[index];
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        System.Console.WriteLine($"{GetRandomPrompt()}");
        System.Console.WriteLine();
        System.Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        System.Console.Write("Beginning in...");
        ShowCountDown(5);

        System.Console.WriteLine();
        System.Console.WriteLine("Ponder on the following questions.");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while(DateTime.Now < endTime)
        {
            System.Console.WriteLine();
            System.Console.Write($">{GetRandomQuestion()}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
    
}