using System;
class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        int userNumber = 0;

        while (userNumber != 5)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do? ");
            userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Enter the filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case 4:
                    Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case 5:
                    Console.WriteLine("See you next time!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }
}