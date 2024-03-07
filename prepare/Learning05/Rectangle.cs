public class Rectangle : Shape
{
    // member variables
    public double Length { get; set; }
    public double Width { get; set; }

    // constructors
    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }

    // methods
    public override double GetArea()
    {
        double area = Length * Width;
        return area;
    }
}