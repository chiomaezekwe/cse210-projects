using System;

class Program
{
    static void Main(string[] args)
    
    // Generate random numbers (as the magic number); initialize the playCount to 0 and playAgain to 'yes'

    {
        Random randomGenerator = new Random(); 
        int playCount = 0; 
        string playAgain = "yes"; 

        while (playAgain.ToLower() == "yes")

        {
            playCount++;            // Incrementing the play count
            int count = 0;          //  Initializing count to 0 for each new game
            int guess = -1;         // Initializing guess to an invalid number initially

            // Generate a random magic number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);

            while (guess != magicNumber)

            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());    // Getting the user's guess
                count++;        // Increment guess count

                // Provide the user with the feedback based on their guess

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!!");
                }
            }

            // Output: Display the number of guesses taken
            Console.WriteLine($"It took {count} guesses.");

            // Ask the user if he or she wants to play again
            Console.Write("Play again? ");
            playAgain = Console.ReadLine(); // Get the user's answer
        }

        // Output: Print a goodbye message and state the total number of times 
        //the user played the guess the magic number game
        Console.WriteLine("Goodbye");
        Console.WriteLine($"You played {playCount} times.");
    }
}

