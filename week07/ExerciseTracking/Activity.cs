using System;
public abstract class Activity   
{
    // Private fields
    private DateTime _date;
    private double _minutes;

    // Public getters and setters with encapsulation
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public double Minutes
    {
        get { return _minutes; }
        set { _minutes = value; }
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get summary of the activity
    public string GetSummary()
    {
        // Format date
        string dateStr = Date.ToString("dd MMM yyyy");
        
        // Get activity details
        return $"{dateStr} {GetType().Name} ({Minutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}