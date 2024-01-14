using System;

class Program
{
    static void Main(string[] args)
    {
        // For the steps 1 and 2
        // Ask the user for the magic number
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        // For the step 3 and strech
        // Generate a random number from 1 to 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        // Ask the user for a guess
        int userGuess = -1;
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            // Determine if the guess is higher, lower, or correct
            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}