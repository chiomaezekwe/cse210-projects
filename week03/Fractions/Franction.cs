using System;
public class Fraction
{
    // Private attributes for numerator and denominator
    private int _top;
    private int _bottom;

    // Constructor with no parameters (defaults to 1/1)
        public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter for the top (sets bottom to 1)
        public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters for top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for the numerator (top)
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for the denominator (bottom)
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return decimal value (floating-point number instead of interger) of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
