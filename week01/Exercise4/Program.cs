using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the list to hold the numbers.
        List<int> numbers = new List<int>();

        // Ask the user to enter desired numbers to make up the list.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());

            // Do not add '0' to the list, rather Stop when the user enters '0'.
            if (input == 0)
            {
                break;
            }

            // To add number to the list.
            numbers.Add(input);
        }

        // No numbers was entered. That is, the user only entered '0', diplay a message and exit.
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Computing the total sum of all the numbers specified in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Computing the average of all the numbers specified in the list.
        float average = ((float)sum) / numbers.Count;

        // Finding the largest number in the list.
        int max = numbers[0];
        foreach (int number in numbers)
        {
            max = Math.Max(max, number);
        }

        // Finding the smallest number in the list.
        int min = numbers[0];
        foreach (int number in numbers)
        {
            min = Math.Min(min, number);
        }

        // Sorting the list
        numbers.Sort();

        // Display the output results of the clculations.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number is: {min}");

        // Display the sorted list.
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
        