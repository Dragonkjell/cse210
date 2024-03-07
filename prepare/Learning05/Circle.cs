public class Circle : Shape
{
    // member variables
    public double Radius { get; set; }

    // constructors
    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    // methods
    public override double GetArea()
    {
        double area = Math.PI * Math.Pow(Radius, 2);
        return area;
    }
}