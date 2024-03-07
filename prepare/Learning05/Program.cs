using System;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle("red", 4);

        Console.WriteLine(circle.GetArea());
        Console.WriteLine(circle.GetColor());
    }
}