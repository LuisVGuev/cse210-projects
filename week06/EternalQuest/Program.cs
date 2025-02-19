using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main()
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        ShowMenu();
    }

    static void ShowMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals and score");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            goals.Add(new SimpleGoal(name, points));
        }
        else if (choice == "2")
        {
            goals.Add(new EternalGoal(name, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter how many times this goal needs to be completed: ");
            int timesRequired = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points for completing this goal: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, points, timesRequired, bonusPoints));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Which goal have you completed?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            goals[choice].RecordEvent();
            totalPoints += goals[choice].Points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("\nYour goals and progress:");
        foreach (var goal in goals)
        {
            goal.Display();
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }
}
