using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        System.Console.WriteLine(math.GetSummary());
        System.Console.WriteLine(math.MathHomeWorkList());

        WritingAssignment writing = new WritingAssignment("The Causes of Word War II", "Mary Waters", "European History");
        System.Console.WriteLine(writing.GetSummary());
        System.Console.WriteLine(writing.GetWritingInformation());
    }
}