using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        
        string choice = Console.ReadLine();
        Activity activity = null;

        switch (choice)
        {
            case "1":
                activity = new BreathingActivity();
                break;
            case "2":
                activity = new ReflectingActivity();
                break;
            case "3":
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        // Run the selected activity
        if (activity != null)
        {
            if (activity is BreathingActivity breathingActivity)
                breathingActivity.Run();
            else if (activity is ReflectingActivity reflectingActivity)
                reflectingActivity.Run();
            else if (activity is ListingActivity listingActivity)
                listingActivity.Run();
        }
    }
}
