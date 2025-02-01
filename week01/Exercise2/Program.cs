using System;

class Program
{
    static void Main(string[] args)
    {
       // Ask for the user's grade percentage
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        
        // Convert the input to an integer
        int grade = int.Parse(userInput);

        // Initialize the letter grade and sign
        string letterGrade = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letterGrade = "A";
            sign = GetSign(grade); // Get the "+" or "-" sign
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            sign = GetSign(grade);
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            sign = GetSign(grade);
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            sign = GetSign(grade);
        }
        else
        {
            letterGrade = "F";
        }

        // Print the grade letter and sign (if applicable)
        if (letterGrade != "F")
        {
            Console.WriteLine($"Your grade is {letterGrade}{sign}");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        // Check if the student passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }

    // Helper function to determine "+" or "-" based on the last digit
    static string GetSign(int grade)
    {
        int lastDigit = grade % 10;
        
        if (lastDigit >= 7)
        {
            return "+";
        }
        else if (lastDigit < 3)
        {
            return "-";
        }
        else
        {
            return ""; // No sign
        }
    }
}