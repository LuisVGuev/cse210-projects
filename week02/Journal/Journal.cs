using System;
using System.Collections.Generic;
using System.IO;

//Journal Class
public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private static readonly List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry(string response)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            foreach (var line in File.ReadLines(filename))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

