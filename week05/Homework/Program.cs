using System;
class Program
{
    static void Main(string[] args)
    {
        // Creating a MathAssignment object.
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "Problems 8-19");
        
        // Display summary and homework list for MathAssignment class.
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // line break for readability.
        Console.WriteLine(); 

        // Create a WritingAssignment object.
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        
        // Display summary and writing information.
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
