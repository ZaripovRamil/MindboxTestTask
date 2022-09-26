namespace MindboxTestTask;

public class Triangle : Polygon
{
    public Triangle(double[] sides) : base(sides)
    {
        if (sides.Length != 3)
            throw new ArgumentException();
    }

    protected override double GetArea()
    {
        var p = Sides.Sum()/2;
        return Math.Sqrt(p*(p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
    }

    public bool IsRightTriangle()
    {
        var squaresSum = Sides.Sum(side => side * side);
        var biggestSide = Sides.Max();
        return Math.Abs(squaresSum - 2 * biggestSide * biggestSide) < 0.001;
    }
}