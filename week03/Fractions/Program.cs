using System;

public class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see God's hand in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had to do one thing today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Random random = new Random();
                string prompt = prompts[random.Next(prompts.Length)];
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                Entry entry = new Entry(date, prompt, response);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the file name to save:");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter the file name to load:");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}
