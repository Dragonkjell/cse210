public class Shape
{
    // member variables
    public string Color { get; set; }
    
    // constructors
    public Shape(string color)
    {
        Color = color;
    }

    // methods
    public virtual double GetArea()
    {
        return 0;
    }

    public string GetColor()
    {
        return Color;
    }
}