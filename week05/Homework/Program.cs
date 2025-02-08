using System;

class Program
{
    static void Main()
    {
        // Create a MathAssignment object
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        
        // Test and print out the results for MathAssignment
        Console.WriteLine(mathAssignment.GetSummary());      
        Console.WriteLine(mathAssignment.GetHomeworkList()); 

        // Create a WritingAssignment object
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        
        // Test and print out the results for WritingAssignment
        Console.WriteLine(writingAssignment.GetSummary());            
        Console.WriteLine(writingAssignment.GetWritingInformation()); 
    }
}
