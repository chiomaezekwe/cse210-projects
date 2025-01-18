using System;

class Program
{
    // The Function to display a welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to ask users for their name and the output returned as a string.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to ask users for their favorite number and the output is returned as an integer.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square the number provided by the users and the output returned as an integer.
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result; ie, Output: name (a string) and the squared number (an integer).
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
    static void Main(string[] args)
    {
        // Call DisplayWelcome Function to show the initial message.
        DisplayWelcome();

        // Call PromptUserName Function to get the user's name.
        string userName = PromptUserName();

        // Call PromptUserNumber Function to get the user's favorite number.
        int favoriteNumber = PromptUserNumber();

        // Call SquareNumber Function to calculate the square of the favorite number.
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call DisplayResult Function to display the result to the user.
        DisplayResult(userName, squaredNumber);
    }
}