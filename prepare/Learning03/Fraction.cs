public class Fraction
{
    private int _top;
    private int _bottom;

    // what these 3 constructors mean is "if you create an instance of this class with no arguments, it will default to 1/1, if you create an instance with one argument, it will default to that whole number, and if you create an instance with two arguments, it will default to that fraction"
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // getters
    public void GetTop()
    {
        Console.WriteLine($"Top: {_top}");
    }
    public void GetBottom()
    {
        Console.WriteLine($"Bottom: {_bottom}");
    }

    // setters
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public double GetDecimalValue()
    {
        return Math.Round((double)_top/_bottom, 2);
    }
    public string GetFractionValue()
    {
        return $"{_top}/{_bottom}";
    }
}