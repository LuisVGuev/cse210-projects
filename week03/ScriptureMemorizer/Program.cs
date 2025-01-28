using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize the scripture library
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        // Get a random scripture from the library
        Scripture scripture = scriptureLibrary.GetRandomScripture();

        // Display the full scripture
        scripture.Display();

        // Start the interactive loop
        while (!scripture.IsFullyHidden())
        {
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWord();
                scripture.Display();
            }
        }

        // Final display with all words hidden
        if (scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.ScriptureReference);
            foreach (var word in scripture.Words)
            {
                Console.Write(new string('_', word.Text.Length) + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nYou have finished memorizing the scripture!");
    }
}