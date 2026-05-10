using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an empty list
        List<int> myNumbers = new List<int>();

        // set a flag to make the while loop condition true
        // end the loop when the user enters 0
        int number = -1;

        while(number != 0)
        {
            Console.Write("Enter a list of numbers (0 to quit): ");
            number = int.Parse(Console.ReadLine());

            // add the number to the list if it is not 0
            if (number != 0)
            {
                myNumbers.Add(number);
            }
        }

        // Iterate through myList and sum numbers
        int sum = 0;
        foreach(int num in myNumbers)
        {
            sum += num;
        }

        // average the numbers in myLlist =
        float average = ((float) sum) / myNumbers.Count; 

        // Find the maximum number
        int max = myNumbers[0];
        foreach(int num in myNumbers)
        {
            if(max < num)
            {
                max = num;
            }
        }
        // Print the sum, average and maximum number;
        Console.WriteLine($"The sum is {sum}"); 
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The average is {max}");


        // sort myNumbers list
        myNumbers.Sort();
        Console.WriteLine("Sorted list: ");
        foreach(int num in myNumbers)
        {
            Console.WriteLine(num);
        }

    }
}
