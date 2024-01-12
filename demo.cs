int x = 5
Console.WriteLine(x);
Console.Write("No line after this one");

Console.Write("What is your favorite color?");
string color = Console.ReadLine();

string school = "Hogwarts";
Console.WriteLine($"I am studying at {school}");

if (x > y)
{
    if (x > z)
    {
        Console.WriteLine("greater than");
    }
}
else if (y > y)
{
    Console.WriteLine("less than");
}
else
{
    Console.WriteLine("neither");
}

// and == &&
// or == ||
// not -- !

string valueInText = "42";
int number = int.Parse(valueInText);

int number = 65;
string textVersion = number.ToString();