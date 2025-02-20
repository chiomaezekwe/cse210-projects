using System;
public class Swimming : Activity   
{
    // Private field
    private int _laps;

    // Public getter and setter for laps
    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    // Constructor to set values for Swimming activity
    public Swimming(DateTime date, double minutes, int laps)
    {
        Date = date;
        Minutes = minutes;
        Laps = laps;
    }

    // Override the GetDistance method to calculate swimming distance
    public override double GetDistance()
    {
        return (Laps * 50) / 1000.0;        // Convert meters to kilometers
    }

    // Override the GetSpeed method to calculate speed in km/h
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / Minutes) * 60;  // km/h
    }

    // Override the GetPace method to calculate pace in min per km
    public override double GetPace()
    {
        double distance = GetDistance();
        return Minutes / distance;  // in min per km
    }
}
