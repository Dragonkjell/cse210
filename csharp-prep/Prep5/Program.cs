using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        Console.WriteLine("");
        DisplayResult(name, favNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string name, int favNumber)
    {
        Console.WriteLine($"Your name is {name}");
        Console.WriteLine($"Your favorite number is {favNumber}");
        int squaredNumber = SquareNumber(favNumber);
        Console.WriteLine($"{name}, your favorite number squared is {squaredNumber}");
    }
}