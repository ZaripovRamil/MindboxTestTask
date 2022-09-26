namespace MindboxTestTask;

public abstract class Polygon : Figure
{
    public Polygon(double[] sides)
    {
        if (sides is null)
            throw new NullReferenceException();
        if (sides.Length < 3 || !AreValidPolygonSides(sides))
            throw new ArgumentException();
        Sides = sides;
    }
    //TODO:add another constructor using dots coordinates array instead of sides array

    private static bool AreValidPolygonSides(double[] sides)
    {
        var sum = sides.Sum();
        return sides.All(value => value < sum - value && value>0);
    }

    public double[] Sides { get; }
}
