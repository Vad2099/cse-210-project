using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a list to store numbers
        List<int> numbersList = new List<int>();

        // Ask the user for a series of numbers and append each one to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput;
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbersList.Add(userInput);
            }

        } while (userInput != 0);

        // Compute the sum of the numbers in the list
        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }

        // Compute the average of the numbers in the list
        double average = (double)sum / numbersList.Count;

        // Find the maximum number in the list
        int maxNumber = numbersList.Count > 0 ? numbersList[0] : 0;
        foreach (int number in numbersList)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}