using System;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
                                      "This activity will help you relax by guiding you through deep breathing. Focus on your breathing as you inhale and exhale slowly.")
    { }

    // Run Breathing Activity
    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);  // Show a spinner for 2 seconds
            Console.WriteLine("Breathe out...");
            ShowSpinner(2);  // Show a spinner for 2 seconds
        }
        
        DisplayEndingMessage();
    }
}