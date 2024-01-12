using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string symbol = "";

        if (grade % 10 >=7)
        {
            symbol = "+";
        }
        else if (grade % 10 <= 3)
        {
            symbol = "-";
        }
        else if (grade >= 97 || grade <= 59)
        {
            symbol = "";
        }
        else
        {
            symbol = "";
        }

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}{symbol}.");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass.");
        }
    }
}