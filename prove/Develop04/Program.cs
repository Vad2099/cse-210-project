using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {   
        int choice  = 0;

        while (choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly.");
                breathingActivity.Run();
                break;

                case 2:
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();
                break;

                case 3:
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
                break;

                case 4:
                Console.WriteLine("See you next time...");
                break;

                default:
                Console.WriteLine("Invalid choice. Please select again.");
                break;
            }
        }

        
    }
}