using System;

public class Fraction
{
    // Declare private attributes that are
    // only accessible with the specified class.
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Create a GetFractionString 
    // that returns a string representation of top and bottom integer
    public string GetFractionString()
    {
        string representation = _top.ToString() + "/" + _bottom.ToString();
        return representation;
    }

    // Create a GetDecimalValue method
    // to return a double
    public double GetDecimalValue()
    {
        double fraction = (double) _top /_bottom;
        return fraction;
    }
    

}
