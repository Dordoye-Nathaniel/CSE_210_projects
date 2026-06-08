using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public double Length{get{return _length;} set{_length = value;}}
    public double Width{get{return _width;} set{_width = value;}}

    public Rectangle(double lenght, double width, string color): base(color)
    {
        Length = lenght;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}