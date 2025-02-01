using System;
using System.Collections.Generic;
using System.Linq; // Import LINQ for sorting
class Program
{
    static void Main(string[] args)
    {
         // Create a list to store the numbers
        List<int> numbers = new List<int>();
        int input;

        // Ask user for numbers, add them to the list until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            
            // Exit condition
            if (input == 0)
            {
                break;
            }

            // Add the number to the list
            numbers.Add(input);
        }

        // Compute the sum
        int sum = numbers.Sum();

        // Compute the average
        double average = numbers.Average();

        // Find the largest number
        int largest = numbers.Max();

        // Display the core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch challenge: Find the smallest positive number
        int smallestPositive = numbers.Where(x => x > 0).DefaultIfEmpty(int.MaxValue).Min();
        
        // Display smallest positive number if there is one
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // Stretch challenge: Sort the numbers and display them
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}