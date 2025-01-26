using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<JournalEntry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();

        // Handle potential file read issues, like file not existing or being empty
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split(" | ");
            if (parts.Length == 3)
            {
                // Ensure that the date is set correctly in the JournalEntry
                string prompt = parts[0];
                string response = parts[1];
                string date = parts[2];

                // Add entry with the correct date
                Entries.Add(new JournalEntry(prompt, response, date));
            }
        }
    }
}
