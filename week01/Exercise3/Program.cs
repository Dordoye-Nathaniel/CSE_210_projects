using System;

class Program
{
    // Create an instance of the random class
    static Random RandomGenerator = new Random();

    static void Main()
    {
        // Generate a random number
        int randomNumber = RandomGenerator.Next(1, 101);

        int guess = 0;    
        int totalGuess = 0;
        while(guess != randomNumber)
        {
            Console.Write("what is your magic number: ");
            guess = int.Parse(Console.ReadLine());
            totalGuess++;
            
            // compare the entered guess and give feedback to either guess
            // higher or lower.
            if(guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        // Display total number of guesses
        Console.WriteLine($"Your total number of guess is {totalGuess}");


    }

}