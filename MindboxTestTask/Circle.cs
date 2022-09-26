namespace MindboxTestTask;

public class Circle : Figure
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentException();
        Radius = radius;
    }

    protected override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}