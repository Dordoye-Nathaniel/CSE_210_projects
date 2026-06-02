using System;

// To exceed the requirements, I added logic that prevents random prompts and questions from repeating until 
// all available options have been used once during the session. I did this by keeping a separate unused list, 
// removing each selected item, and refilling the list only after every prompt or question has been used.
class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectingActivity = new ReflectionActivity();
        ;ListingActivity listingActivity = new ListingActivity();

        Console.Clear();



        while (true)
        {
            System.Console.WriteLine("1. Start breathing activity.");
            System.Console.WriteLine("2. Start reflecting activity.");
            System.Console.WriteLine("3. Start listing activity.");
            System.Console.WriteLine("4. Quit.");

            System.Console.Write("Select a choice from the menu:");
            string userEntry = Console.ReadLine()!;
            if(userEntry == "4" || userEntry.ToLower() == "quit")
            {
                System.Console.WriteLine("Program ended!");
                break;
            }

            else if(userEntry == "1")
            {
                breathingActivity.Run();
            }
            else if (userEntry == "2")
            {
                reflectingActivity.Run();
            }
            else if(userEntry == "3")
            {
                listingActivity.Run();
            }

        }

    }



}