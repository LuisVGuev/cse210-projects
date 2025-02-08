using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing Activity", "This activity will help you list your thoughts", 60)
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "What made you happy today?",
            "What did you learn today?"
        };
    }

    // Add 'override' keyword 
    public override void StartActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine("Take a moment and list your responses to the following prompts:");
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetListFromUser()
    {
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please provide a valid response.");
            }
            else
            {
                _count++;
            }
        }
        Console.WriteLine($"You listed {_count} items.");
    }
}

