using System;
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor that accepts color, length, and width, and also calls the base constructor for color.
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea() method to return the area of a rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}
