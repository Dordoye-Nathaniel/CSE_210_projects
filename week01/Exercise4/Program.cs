using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // Store list in myList
        // Remove the last element 0
        List<int> myList = UserInput();
        myList.Remove(0);
        Console.WriteLine("You entered: ");

        // Iterate through myList and calculate:
        // sum, average, and maximum number.
        int sum = 0;
        foreach(int num in myList)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/myList.Count}");
        Console.WriteLine($"The largest number is: {myList.Max()}");

        // Finding the smallest positive number
        int smallestPositive = myList.Where(n=> n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sorted list
        myList.Sort();
        foreach(int num in myList)
        {
        Console.WriteLine($"Sorted list: {num}"); 
        }
    }

    static List<int> UserInput()
    {
        // Program ends when user enters 0
        Console.WriteLine("Enter '0' to quit.");

        // Create an object of the List class
        List<int> numeral = new List<int>();

        // Set a flag. When user enters 0, flag sets to no and program stops.
        string flag = "yes";

        // Block for user input and updting the numeral list
        // Returns a list
        while (flag == "yes")
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            numeral.Add(number);

            if(number == 0)
            {
                Console.WriteLine("Quiting game");
                flag = "no";
            }
        }
        return numeral;
        
    }
}
