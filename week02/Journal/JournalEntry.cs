using System;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // Constructor accepting the date as well
    public JournalEntry(string prompt, string response, string date = null)
    {
        Prompt = prompt;
        Response = response;
        Date = date ?? DateTime.Now.ToShortDateString(); // Default to current date if not provided
    }

    public override string ToString()
    {
        return $"{Prompt} | {Response} | {Date}";
    }
}
