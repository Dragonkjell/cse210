using System;
using System.Diagnostics;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an activity: ");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflecting");
        Console.WriteLine("3. Listing");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.ShowSpinner();

                breathingActivity.SetStartingMessage("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(breathingActivity.GetStartingMessage());

                Console.Write("Enter the duration for the breathing activity (in seconds): ");
                int duration = int.Parse(Console.ReadLine());
                breathingActivity.ShowSpinner();

                breathingActivity.BreathTimer(duration);

                breathingActivity.SetEndingMessage($"Well done! You completed {duration} seconds of the breathing activity.");
                Console.WriteLine(breathingActivity.GetEndingMessage());
                break;

            case 2:
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.ShowSpinner();

                reflectingActivity.SetStartingMessage("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine(reflectingActivity.GetStartingMessage());

                Console.Write("Enter the duration for the reflecting activity (in seconds): ");
                duration = int.Parse(Console.ReadLine());
                reflectingActivity.ShowSpinner();
                
                Console.WriteLine(reflectingActivity.GetPrompt());
                reflectingActivity.ShowSpinner();

                reflectingActivity.PromptQuestion(duration);

                reflectingActivity.SetEndingMessage($"Well done! You completed {duration} seconds of the reflecting activity.");
                Console.WriteLine(reflectingActivity.GetEndingMessage());
                break;

            case 3:
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.ShowSpinner();

                listingActivity.SetStartingMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine(listingActivity.GetStartingMessage());

                Console.Write("Enter the duration for the listing activity (in seconds): ");
                duration = int.Parse(Console.ReadLine());
                listingActivity.ShowSpinner();

                listingActivity.ListItems(duration);
                
                listingActivity.SetEndingMessage($"Well done! You completed {duration} seconds of the listing activity. You listed {listingActivity.ItemCount()} items.");
                Console.WriteLine(listingActivity.GetEndingMessage());

                break;

            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
    }
}