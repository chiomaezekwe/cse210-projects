using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)

    // I added additional code to show the grade sign for the stretch challenge. 
    // I added lines 22, 26 - 35, 41 - 48, 54 - 61, 67 - 74,81 - 88, and 92
    
    {

    // Ask the user for their score

        Console.Write("What is your score? ");
        string answer = Console.ReadLine();
        int score = int.Parse(answer);

    // Determine the grade letter based on the user's score provided

        string letter; 
        string sign = "";    // this is to store the grade sign

        if (score >= 90)
        {
            letter = "A";

            if (score % 10 >= 7) 
            {
                sign = "+";   // exceptional cases of A+, F+, or F; A+ is not valid, so output is A
            }
            else if (score % 10 < 3) 
            {
                sign = "-"; // A- for scores with the last digit below 3
            }
        }
        else if (score >= 80)
        {
            letter = "B";

            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (score >= 70)
        {
            letter = "C";

            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (score >= 60)
        {
            letter = "D";

            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F";

             // exceptional cases of A+, F+, or F; F does not get a '+' or '-' sign
            sign = "";
        }

        // exceptional cases of A+, F+, or F; If grade is A+, set the sign to "" (no A+)
        if (letter == "A" && sign == "+")

        {
            sign = ""; 
        }

        // Print the letter grade
        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}
