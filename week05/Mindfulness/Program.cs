using System;

class Program
{
    static void Main(string[] args)
    {
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
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userEntry == "2")
            {
                ReflectionActivity reflectingActivity = new ReflectionActivity();
                reflectingActivity.Run();
            }
            else if(userEntry == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

        }

    }



}