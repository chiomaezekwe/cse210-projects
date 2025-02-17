using System;
public class ReflectingActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectingActivity() : base("Reflection Activity", 
                                       "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    // Run Reflecting Activity
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];
        Console.WriteLine("Prompt: " + prompt);
        ShowSpinner(3);  // Show spinner for few seconds

        // Asking a few reflection questions
        string[] questions = {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "What did you learn from this experience?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?"
        };
        
        foreach (var question in questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);  // Simulate pause for reflection
        }

        DisplayEndingMessage();
    }
}