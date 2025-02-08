using System;
using System.Threading;

public class Activity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Duration { get; private set; }

    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {this.Name}: {this.Description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {this.Name}. Well done!");
    }

    // Spinner animation 
    public void ShowEnhancedSpinner(int seconds)
    {
        string[] spinnerChars = { ".", "o", "O", "*", "^", "%" };
        Console.Write("Loading");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }

    // Countdown timer
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    // StartActivity virtual 
    public virtual void StartActivity()
    {
        Console.WriteLine("Starting the activity...");
    }
}

