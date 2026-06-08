using System;

public class Square : Shape
{
    private double _side;

    public double Side{get{return _side;} set{_side = value;}}
    
    public Square(double side, string color): base(color)
    {
        Side = side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }

}