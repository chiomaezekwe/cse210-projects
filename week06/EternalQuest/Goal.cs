using System;
public abstract class Goal
{
    //Encapsulation; Properties 
    private string _shortName;
    private string _description;
    private int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Encapsulation, accessed via methods Getters
    public string ShortName { get => _shortName; }
    public string Description { get => _description; }
    public int Points { get => _points; }

    // Abstract Methods for Derived Classes
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}