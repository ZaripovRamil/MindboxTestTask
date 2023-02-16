using System.Collections.Immutable;

namespace MindboxTestTask;

public abstract class Polygon : Figure
{
    protected Polygon(IEnumerable<double> sides)
    {
        Sides = sides.ToArray();
        if (Sides.Length < 3 || !AreValidPolygonSides())
            throw new ArgumentException();
        
    }

    protected Polygon(IEnumerable<int> sides) : this(sides.Select(i => (double) i))
    {}
    
    //TODO:add another constructor using dots coordinates array instead of sides array

    private bool AreValidPolygonSides()
    {
        var sum = Sides.Sum();
        return Sides.All(value => value < sum - value && value>0);
    }

    protected double[] Sides { get; }
}
