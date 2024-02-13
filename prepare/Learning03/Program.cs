using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        // you can use "var" instead of the datatype
        // "var fraction = new Fraction();" instead of "Fraction fraction = new Fraction();"

        fraction.SetTop(5);
        fraction.SetBottom(7);
        fraction.GetTop();
        fraction.GetBottom();

        Console.WriteLine($"{fraction.GetFractionValue()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");
    }
}