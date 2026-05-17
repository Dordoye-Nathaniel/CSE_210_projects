using System;


using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Private list of entries (hidden from outside)
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry
    public void AddEntry(string prompt, string response, string date)
    {
        Entry entry = new Entry();
        entry.SetEntry(prompt, response, date);
        _entries.Add(entry);
    }

    // Display all entries
    public void DisplayJournal()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e.Display());
        }
    }

    // Save journal to file
    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                writer.WriteLine($"{e.GetDate()}|{e.GetPrompt()}|{e.GetResponse()}");
            }
        }
    }

    // Load journal from file
    public void LoadJournal(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry e = new Entry();
            e.SetEntry(parts[1], parts[2], parts[0]); // prompt, response, date
            _entries.Add(e);
        }
    }
}

