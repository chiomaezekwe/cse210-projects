using System;
public class Running : Activity         
{
    // Private field
    private double _distance;

    // Public getter and setter for distance
    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    // Constructor to set values for the Running activity
    public Running(DateTime date, double minutes, double distance)
    {
        Date = date;
        Minutes = minutes;
        Distance = distance;
    }

    // Override the GetDistance method (returns the distance already provided)
    public override double GetDistance()
    {
        return Distance; // Already provided in kilometers
    }

    // Override the GetSpeed method to calculate speed in km/h
    public override double GetSpeed()
    {
        return (Distance / Minutes) * 60; // km/h
    }

    // Override the GetPace method to calculate pace in min per km
    public override double GetPace()
    {
        return Minutes / Distance; // min/km
    }
}