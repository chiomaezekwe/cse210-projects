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
            Console.WriteLine("1. New entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string entryText = Console.ReadLine();
                    Entry newEntry = new Entry(prompt, entryText);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added.");

                    break;

                case "2":
                    // Display all journal entries
                    journal.DisplayAll();
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();

                    break;

                case "3":
                    // Save to a file 
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    
                    break;

                case "4":
                    // Load from a file
                    Console.Write("Enter the filename to load the journal from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                
                    break;

                case "5":
                    // Exit the program
                    running = false;

                    break;

                default:
                    // Invalid option message
                    Console.WriteLine("Invalid option. Please choose again.");
                    
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