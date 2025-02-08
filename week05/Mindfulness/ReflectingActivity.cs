using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on certain prompts", 60)
    {
        _prompts = new List<string>
        {
            "Think about a time you felt proud. What happened?",
            "Think about a time you learned something new. What was it?"
        };
        _questions = new List<string>
        {
            "How did this make you feel?",
            "What did you learn from this experience?"
        };
    }

    // Use StartActivity
    public override void StartActivity()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
    }

    public void DisplayQuestions()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count)];
        Console.WriteLine($"Question: {question}");
    }
}

