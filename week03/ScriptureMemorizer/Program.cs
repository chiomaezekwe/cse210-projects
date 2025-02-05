using System;
class Program
{
    static void Main(string[] args)
    {
        // Initializing a list of scriptures to be displayed to the user.
        var scriptures = new[]
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Isaiah", 55, 8), "For My thoughts are not your thoughts, neither are your ways My ways, saith the Lord."),
            new Scripture(new Reference("Jeremiah", 29, 11), "For I know the thoughts that I think toward you, saith the Lord, thoughts of peace, and not of evil, to give you an expected end."),
            new Scripture(new Reference("Isaiah", 55, 9), "For as the heavens are higher than the earth, so are My ways higher than your ways, and My thoughts than your thoughts."),
            new Scripture(new Reference("Matthew", 5, 9), "Blessed are the peacemakers, for they will be called children of God."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            new Scripture(new Reference("Matthew", 7, 7), "Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you."),
            new Scripture(new Reference("Galatians", 5, 22,23), "But the fruit of the Spirit is love, joy, peace, forbearance, kindness, goodness, faithfulness, gentleness and self-control."),
            new Scripture(new Reference("Matthew", 6, 33), "But seek ye first the kingdom of God, and His righteousness; and all these things shall be added unto you."),
            new Scripture(new Reference("Psalm", 34, 18), "The Lord is near to the brokenhearted and saves the crushed in spirit."),
            new Scripture(new Reference("John", 1, 12), "But as many as received Him, to them gave He power to become the sons of God, even to those who believe in His name."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.")
        };

        // Display a menu to the user to choose from a list of scriptural quotes
        Console.WriteLine("Choose a scripture:");
        for (int i = 0; i < scriptures.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetDisplayText()}");
        }

        // Get user's scripture choice
        int selectedScripture = 0;
        while (true)
        {
            Console.Write("\nEnter the number of your chosen scripture: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out selectedScripture) && selectedScripture >= 1 && selectedScripture <= scriptures.Length)
            {
                selectedScripture--; // Adjust for 0-based indexing
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 13.");
            }
        }

        // Get the chosen scripture
        Scripture scripture = scriptures[selectedScripture];
        Console.Clear();

        // Display the chosen scripture with all its words visible
        Console.WriteLine("Initial scripture:");
        Console.WriteLine(scripture.GetDisplayText());

        // Main loop:- for hiding words
        while (true)
        {
            Console.WriteLine("\nPress Enter to hide some words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a random set of word(s)
            scripture.HideRandomWords(1);

            // Display the updated scripture with some words hidden
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // If all words are hidden; end program
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! Game is over.");
               break;
            }
        }

        Console.WriteLine("\nThanks, goodbye!");
    }
}
