using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("New entry");
            Console.WriteLine("Display entries");
            Console.WriteLine("Save to a file");
            Console.WriteLine("Load from a file");
            Console.WriteLine("Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry 
                    break;

                case "2":
                    // Display all journal entries
                    break;

                case "3":
                    // Save to a file 
                    break;

                case "4":
                    // Load from a file
                    break;

                case "5":
                    // Exit the program
                    running = false;
                    break;

                default:
                    // Invalid option message
                    break;
            }

            if (running)
            {
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}