public class Square : Shape
{
    // member variables
    public double Side { get; set; }

    // constructors
    public Square(string color, double side) : base(color)
    {
        Side = side;
    }

    // methods
    public override double GetArea()
    {
        double area = Side * Side;
        return area;
    }
}