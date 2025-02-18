using System;
public class Square : Shape
{
    private double _side;

    // Constructor that accepts color and side, and also calls the base constructor for color.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the GetArea() method to return the area of a square
    public override double GetArea()
    {
        return _side * _side;
    }
}
