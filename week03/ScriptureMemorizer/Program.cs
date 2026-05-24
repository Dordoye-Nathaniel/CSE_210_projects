using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Creativity Report ---
        // 1. Added a scripture library with random selection.
        // 2. Enabled loading scriptures from a file.
        // 3. Implemented progressive hiding challenge mode.
        // These features help users practice memorization in varied, realistic ways.

        // Build library (hardcoded + file loading)
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that who"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding")
        };
        // Load from file if available (format: Book|Chapter|Verse|Text)
        if (File.Exists("scriptures.txt"))
        {
            string[] lines = File.ReadAllLines("scriptures.txt");
            foreach (string line in lines)
            {
                var parts = line.Split('|');
                Reference r = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                library.Add(new Scripture(r, parts[3]));
            }
        }
        // Pick a random scripture
        Random rand = new Random();
        Scripture chosen = library[rand.Next(library.Count)];

        Console.WriteLine("Memorization Challenge!");
        Console.WriteLine(chosen.GetDisplayText());

        // Progressive hiding loop
        int round = 1;
        while (!chosen.IsCompletelyHidden())
        {
            Console.WriteLine($"\nRound {round}: Press Enter to hide more words...");
            Console.ReadLine();
            chosen.HideRandomWords(round * 2); // hide more each round
            Console.WriteLine(chosen.GetDisplayText());
            round++;
        }

        Console.WriteLine("\nAll words hidden! Challenge complete.");
    }
}