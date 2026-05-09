using System;

class Program
{
    // Create an instance of the random class
    static Random RandomGenerator = new Random();

    static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Call funciton to start the guess game
        GuessCompareRandom();
    }

    static int Generator()
    {
        // Store the random number generated in randonNumber variable
        // Return the random number
        int randomNumber = RandomGenerator.Next(1, 101);
        return randomNumber;
    }

    static void GuessCompareRandom()
    {
        // Call the random generator method and store the number in random variable
        int random = Generator();

        // number of guess
        int guessCount = 0;

        // declare a flag to reset the while loop 
        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Guess a magic number: ");
            int guess = int.Parse(Console.ReadLine());  
            guessCount++;

            if(guess > random)
            {
                Console.WriteLine("Lower!");
            }
            else if(guess < random)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine($"You guessed right in {guessCount} !");
                response = "no";
            }
        }
    }   
}