using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries;

    public Journal()
    {
        entries = new List<JournalEntry>();
    }

    public void AddEntry(string prompt, string response)
    {
        JournalEntry newEntry = new JournalEntry(prompt, response);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadJournal(string filename)
    {
        entries.Clear();
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0].Trim();
                    string prompt = parts[1].Trim();
                    string response = parts[2].Trim();

                    JournalEntry entry = new JournalEntry(prompt, response)
                    {
                        Date = date
                    };
                    entries.Add(entry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal: " + ex.Message);
        }
    }

    public int GetEntryCount()
    {
        return entries.Count;
    }
}
