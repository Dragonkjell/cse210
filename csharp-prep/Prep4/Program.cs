using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        List<int> numbers = new List<int>();
        int enteredNumber = -1;

        Console.WriteLine("(Enter some numbers, press 0 when done)");

        while (enteredNumber != 0)
        {
            Console.Write("Enter a number: ");
            enteredNumber = int.Parse(Console.ReadLine());
            numbers.Add(enteredNumber);
        }

        // Compute the sum, or total, of the numbers in the list.
        int numberSum = numbers.Sum();
        
        // alternate way
        // int sum = 0;
        // foreach (int number in numbers)
        // {
        //     sum += number;
        // }
        Console.WriteLine($"Sum: {numberSum}");


        // Compute the average of the numbers in the list.
        double numberAverage = numbers.Average();
        

        // alternate way
        // float average = (numberSum / numbers.Count());
        Console.WriteLine($"Average: {numberAverage}");


        // Find the maximum, or largest, number in the list.
        int numbersMax = numbers.Max();
        
        // alternate way
        // int max = 0;
        // foreach (int number in numbers)
        // {
        //     if number > max)
        //     {
        //         max = number;
        //     }
        // }

        Console.WriteLine($"Max: {numbersMax}");

        // find the smallest positive number
        int smallPosNum = 100000;
        foreach (int number in numbers)
        {
            if (number < smallPosNum && number > 0)
            {
                smallPosNum = number;
            }
        }
        Console.WriteLine($"Smallest positive number: {smallPosNum}");

        // sort the list of numbers and display the sorted list
        numbers.Sort();
        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}