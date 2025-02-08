using System;

public class Program
{
    public static void Main()
    {
        // creation of the activities
        Activity breathing = new BreathingActivity();
        Activity listing = new ListingActivity();
        Activity reflecting = new ReflectingActivity();

        // Display the menu
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Choose an activity to perform:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Listing");
        Console.WriteLine("3. Reflecting");

        string choice = string.Empty;
        bool validChoice = false;

        // Loop until a valid choice
        while (!validChoice)
        {
            Console.Write("Enter choice (1, 2, or 3): ");
            choice = Console.ReadLine();

            // Check input
            if (choice == "1" || choice == "2" || choice == "3")
            {
                validChoice = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            }
        }

        // the chosen activity
        switch (choice)
        {
            case "1":
                breathing.StartActivity();
                break;
            case "2":
                listing.StartActivity();
                break;
            case "3":
                reflecting.StartActivity();
                break;
            default:
                break;
        }
    }
}
