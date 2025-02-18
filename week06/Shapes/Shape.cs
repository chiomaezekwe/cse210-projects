using System;
public abstract class Shape
{
    private string _color;

    // Constructor to initialize color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Setter for color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method for GetArea(), to be overridden in derived classes
    public virtual double GetArea()
    {
        // Default implementation, should be overridden in subclasses
        return 0.0; 
    }
}
