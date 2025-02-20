using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _playerName;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _playerName = "Player"; 
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest!");
        Console.Write("Please enter your name: ");
        _playerName = Console.ReadLine(); 
        ShowMenu();
    }

    private void ShowMenu()
    {
        Console.WriteLine($"Welcome, {_playerName}!");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. List Goals");
        Console.WriteLine("4. Display Player Info");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Exit");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();
        HandleMenuChoice(choice);
    }

    private void HandleMenuChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                RecordEvent();
                break;
            case "3":
                ListGoals();
                break;
            case "4":
                DisplayPlayerInfo();
                break;
            case "5":
                SaveGoals();
                break;
            case "6":
                LoadGoals();
                break;
            case "7":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        if (choice != "7") ShowMenu();  // this will show the menu until the user exits
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();
        Goal goal = null;

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count for the goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the goal: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record progress for?");
        ListGoals();
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. { _goals[i].ShortName}: { _goals[i].GetDetailsString()}");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player: {_playerName}");
        Console.WriteLine($"Player Score: {_score} points");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            // Save player name and score
            writer.WriteLine($"PlayerName:{_playerName}");
            writer.WriteLine($"Score:{_score}");

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            var lines = File.ReadAllLines("goals.txt");
            bool scoreLoaded = false;
            bool playerNameLoaded = false;

            foreach (var line in lines)
            {
                try
                {
                    // Check if it's the player name line
                    if (line.StartsWith("PlayerName:"))
                    {
                        _playerName = line.Split(":")[1];
                        playerNameLoaded = true;
                        continue;  // Skip to the next line
                    }

                    // Check if it's the score line
                    if (line.StartsWith("Score:"))
                    {
                        _score = int.Parse(line.Split(":")[1]);
                        scoreLoaded = true;
                        continue;  // Skip to the next line
                    }

                    // Split by ":" to identify goal type and details
                    string[] parts = line.Split(":");

                    if (parts.Length != 2)
                    {
                        Console.WriteLine($"Skipping invalid line: {line}");
                        continue;
                    }

                    // Get goal details after type prefix
                    string[] goalData = parts[1].Split(",");

                    if (goalData.Length == 0)
                    {
                        Console.WriteLine($"Skipping invalid goal data: {line}");
                        continue;
                    }

                    Goal goal = null;

                    // Load specific types of goals based on the first part of the line
                    if (parts[0] == "SimpleGoal" && goalData.Length == 4)
                    {
                        goal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                    }
                    else if (parts[0] == "EternalGoal" && goalData.Length == 3)
                    {
                        goal = new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]));
                    }
                    else if (parts[0] == "ChecklistGoal" && goalData.Length == 6)
                    {
                        goal = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                    }

                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Skipping unknown goal type or invalid data: {line}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading goal: {ex.Message}. Skipping line.");
                }
            }
            if (playerNameLoaded)
            {
                Console.WriteLine($"Welcome back, {_playerName}!");
            }
            if (scoreLoaded)
            {
                Console.WriteLine("Goals and score loaded successfully.");
            }
            else
            {
                Console.WriteLine("Goals loaded but score data is missing.");
            }
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
