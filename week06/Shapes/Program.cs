using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        List<Shape> shapes = new List<Shape>
        {
            new Square(5, "Blue"),
            new Circle(2, "Green"),
            new Rectangle(6, 5, "Cyan")
        };

        foreach(Shape shape in shapes)
        {
            System.Console.WriteLine($"Color: {shape.GetColor()}");
            System.Console.WriteLine($"Area: {shape.GetArea()}");
            System.Console.WriteLine();
        }
    }
}