using System;
public class Cycling : Activity   
{
    // Private field
    private double _speed;

    // Public getter and setter for speed
    public double Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    // Constructor to set values Cycling activity
    public Cycling(DateTime date, double minutes, double speed)
    {
        Date = date;
        Minutes = minutes;
        Speed = speed;
    }

    // Override the GetDistance method to calculate distance based on speed
    public override double GetDistance()
    {
        return (Speed * Minutes) / 60;    // distance in kilometers
    }

    // Override the GetSpeed method (already provided as an input)
    public override double GetSpeed()
    {
        return Speed;  // the speed is already provided
    }

    // Override the GetPace method to calculate pace in minutes per km
    public override double GetPace()
    {
        return 60 / Speed;  // min/km
    }
}
