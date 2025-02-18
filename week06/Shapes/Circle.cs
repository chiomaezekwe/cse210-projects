using System;
public class Circle : Shape
{
    private double _radius;

    // Constructor that will accepts color and radius, and also calls the base constructor for color
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea() method to return the area of a circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
