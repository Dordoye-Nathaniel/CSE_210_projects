using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Ask user for exams score
        // and compute the grades.
        Console.Write("Enter your exam score: ");
        int mark = int.Parse(Console.ReadLine());
        int score = Grade(mark);
        int sign = GradeSign(mark);
        int status = PassOrNot(mark);
    }    

    static int Grade(int mark)
    {
        // Create a variable to hold the grades
        string letter;

        // Code goes here 
        if (mark >= 90)
        {
            letter = "A";
        }
        else if(mark >= 80 && mark < 90)
        {
            letter = "B";
        }
        else if(mark >= 70 && mark < 80)
        {
            letter = "c";
        }
        else if(mark >= 60 && mark < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        // Display grade by writing letter to terminal
        Console.Write($"Grade: {letter}");
        return 0;
    }

    static int GradeSign(int mark)
    {

        int LastDigit = mark%10;
        string sign;
        // Add '+' or '-' based on the last digit
        // Last digits that are greater than or equal to 7 and
        // score is <= 97, add '+'
        // Last digits that are less than 3, and 
        // score is >= 60, add '-' 
        if(LastDigit >= 7 && mark <= 97)
        {
            sign = "+";
        }
        else if(LastDigit < 3 && mark >= 60)
        {
            sign = "-";
        }
        else
        {
            sign = " ";
        }

        Console.WriteLine($"{sign}");
        return 0;
    }

    static int PassOrNot(int mark)
    {
        // Pass or Fail conditional block
        // A user passes when the entered score is greater than
        // or equal to 70.
        if(mark >= 70)
        {
        Console.WriteLine("Congratulations. You have a Pass!");
        }
        else
        {
        Console.WriteLine("Better luck next time!");
        }
        return 0;
    }    
}