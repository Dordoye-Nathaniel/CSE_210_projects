using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayResult();
    }

    static void DisplayWelcome(string message)
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(string name)
    {
        // Ask for username
        Console.Write("Enter your user name: ");
        name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(int number)
    {
        // Ask for user number
        Console.Write("Enter your favorite number: ");
        number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        // return the square of the number
        
        number = PromptUserNumber(0);
        return number * number;        
    }

    static void DisplayResult()
    {
        // Display username and the squared number 
        string UserName = PromptUserName("");
        int NumberSquared = SquareNumber(0);

        Console.WriteLine($"{UserName}, the squared of your number is {NumberSquared}");
    }
}