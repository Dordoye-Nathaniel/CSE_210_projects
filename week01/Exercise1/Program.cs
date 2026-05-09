using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program to print user name!");

        // Ask user for surname and firstname separately
        Console.WriteLine("Enter your surname: ");
        string SurName = Console. ReadLine();
        Console.WriteLine("Enter your firstname: ");
        string FirstName = Console. ReadLine();

        // concatenate firstname and surname
        string name = FirstName + " " + SurName;

        // Display name
        Console.WriteLine($"Your name is {SurName}, {name}");
        
    }

}