

using System;
using System.Collections.Generic;

// Exceeding Requirements Report
// In addition to the core requirements, I added:
// 1. Randomized prompts to reduce writer’s block.

class Program
{
    static void Main()
    {
        Journal _journal = new Journal();
        List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rand = new Random();
        int choice;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string _prompt = _prompts[rand.Next(_prompts.Count)];
                    Console.WriteLine(_prompt);
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    _journal.AddEntry(_prompt, response, date);
                    break;

                case 2:
                    _journal.DisplayJournal();
                    break;

                case 3:
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    _journal.SaveJournal(saveFile);
                    break;

                case 4:
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    _journal.LoadJournal(loadFile);
                    break;
            }

        } while (choice != 5);
    }
}
