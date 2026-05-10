using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);
        
        DisplayResult(userName, squareNumber);
 
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        // Ask for username
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        // Ask for user number
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        // return the square of the number
        return number * number;        
    }

    static void DisplayResult(string name, int square)
    {
        // Display username and the squared number
        Console.WriteLine($"{name}, the squared of your number is {square}");
    }
}