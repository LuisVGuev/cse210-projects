using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will guide you through breathing exercises", 60) {}

    // Use the 'override' keyword 
    public override void StartActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine("Take a deep breath in...");
        ShowEnhancedSpinner(2); // animation
        Console.WriteLine("Now breathe out...");
        ShowEnhancedSpinner(2); 
        DisplayEndingMessage();
    }
}

