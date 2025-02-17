using System;
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // GetSummary method (common to all activities)
    public string GetSummary()
    {
        return $"{_name}: {_description}";
    }

    // Display starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("How many seconds do you want to spend on this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);  // Show spinner for few seconds
    }

    // Display ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds.");
        ShowSpinner(3);  // Show spinner for few seconds
    }

    // Show spinner animation
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");  // To clear or erase the spinner
            index = (index + 1) % spinner.Length;
        }
    }
}