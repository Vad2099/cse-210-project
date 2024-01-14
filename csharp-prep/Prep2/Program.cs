using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type your grade porcentage: ");
        string porcentageFromUser = Console.ReadLine();
        int percent = int.Parse(porcentageFromUser);

        string letter = "";

        // Determine the letter grade based on the percentage
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign based on the last digit
        int lastDigit = percent % 10;
        string sign = " ";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3 && percent != 100) // Exclude 100% from F- case
        {
        sign = "-";
        }

        // Handle exceptional cases (A+, F+, F-)
        if (letter == "A" && sign == "+")
        {
            letter = "A";
            sign = " ";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            letter = "F";
            sign = " ";
        }

        // Print the letter grade and sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Check if the user passed the course
        if (percent >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard for next time. You can do it!");
        }

    }
}