using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        string[] prompts = {
            "What was the best part of your day?",
            "What did you learn today?",
            "How did you show kindness today?",
            "What are you grateful for today?",
            "What was something challenging today?"
        };
        
        Random random = new Random();  // Move Random object creation outside of loop

        while (true)
        {
            Console.WriteLine("\nJournal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine("Your response:");
                string response = Console.ReadLine();
                journal.AddEntry(prompt, response);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter filename to save:");
                string filename = Console.ReadLine();
                try
                {
                    journal.SaveJournal(filename);
                    Console.WriteLine("Journal saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving journal: {ex.Message}");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter filename to load:");
                string filename = Console.ReadLine();
                try
                {
                    journal.LoadJournal(filename);
                    Console.WriteLine("Journal loaded successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading journal: {ex.Message}");
                }
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}

