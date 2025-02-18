using System;

class Program

{
    static void Main(string[] args)

    {
        // Creating instances of Square, Rectangle, and Circle
        Square square = new Square("Red", 5.0);
        Rectangle rectangle = new Rectangle("Blue", 4.0, 6.0);
        Circle circle = new Circle("Green", 3.0);

        // Create a list of Shape objects
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Iterate through the list and display the color and area of each shape
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            
            // Blank line for better readability
            Console.WriteLine();
        }
    }
}
