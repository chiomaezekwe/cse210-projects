using System;
public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
                                    "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    { }

    // Run Listing Activity
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine("Prompt: " + prompt);
        
        Console.WriteLine("You have 10 seconds to list as many things as you can.");
        ShowSpinner(2);  // Show a spinner for 2 seconds

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter item (or press Enter to finish): ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items.");
        DisplayEndingMessage();
    }
}