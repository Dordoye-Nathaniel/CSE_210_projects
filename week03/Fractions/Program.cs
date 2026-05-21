using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        // Create an instanace of the Fraction class
        // in Program class. Call the instance "f"
        Fraction f = new Fraction(3,4);
        System.Console.WriteLine(f.GetFractionString());
        System.Console.WriteLine(f.GetDecimalValue());
    
    }
}