using System;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using System.Numerics;

public class Circle : Shape
{
    private double _radius;

    public double Radius{get{return _radius;} set{_radius = value;}}

    public Circle(int radius, string color) : base(color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}