using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        // Repeat the game if the user wants to
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;
            
            Console.WriteLine("Welcome to Guess My Number!");

            // Keep looping until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Ask for the user's guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;  // Increment the guess counter
                
                // Compare the guess with the magic number
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Inform the user how many guesses they made
            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");

            // Ask if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}