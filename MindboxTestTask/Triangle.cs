namespace MindboxTestTask;

public class Triangle : Polygon
{
    public Triangle(IEnumerable<double> sides) : base(sides)
    {
        if (!IsTriangle())
            throw new ArgumentException();
    }
    public Triangle(IEnumerable<int> sides) : base(sides) {}

    private bool IsTriangle() => Sides.Length == 3 && Sides.Sum() > 2 * Sides.Max();

    protected override double GetArea()
    {
        var p = Sides.Sum()/2;
        return Math.Sqrt(p*(p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
    }

    public bool IsRightTriangle()
    {
        var squaresSum = Sides.Sum(side => side * side);
        var biggestSide = Sides.Max();
        return Math.Abs(squaresSum - 2 * biggestSide * biggestSide) < double.Epsilon;
    }
}