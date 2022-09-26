using MindboxTestTask;
using NUnit.Framework;

namespace FigureClassTests;

[TestFixture]
public class TriangleTests
{
    readonly Action<double[]> creatingTriangle = sides =>
    {
        var triangle = new Triangle(sides);
    };

    private const double Sqrt2 = 1.4142135623730951;
    private const double Sqrt3 = 1.7320508075688772;


    [Test]
    [TestCase(new double[] { })]
    [TestCase(new double[] {1})]
    [TestCase(new double[] {1, 1})]
    [TestCase(new double[] {1, 1, 1})]
    [TestCase(new double[] {2, 2, 2, 2})]
    public void TriangleCanHaveOnly3Sides(double[] sides)
    {
        if (sides.Length != 3)
            Assert.Throws<ArgumentException>(() => creatingTriangle(sides));
        else
            Assert.DoesNotThrow(() => creatingTriangle(sides));
    }

    [Test]
    public void SidesArrayIsNull_ThrowsException()
    {
        Assert.Throws<NullReferenceException>(() => creatingTriangle(null));
    }

    [Test]
    [TestCase(new double[] {1, 1, 2})]
    [TestCase(new double[] {1, 1, 3})]
    [TestCase(new double[] {0, 1, 1})]
    [TestCase(new double[] {-1, -1, -1})]
    public void InvalidSidesData_ThrowsException(double[] sides)
    {
        Assert.Throws<ArgumentException>(()=>creatingTriangle(sides));
    }

    [TestCase(new double[] {3, 4, 5}, 6)]
    [TestCase(new double[] {5, 12, 13}, 30)]
    [TestCase(new double[] {Sqrt2, Sqrt2, 2}, 1)]
    [TestCase(new double[] {1, 1, 1}, Sqrt3 / 4)]
    [Test]
    public void AreaCorrectlyCounted(double[] sides, double expectedArea)
    {
        var triangle = new Triangle(sides);
        Assert.AreEqual(expectedArea, triangle.Area, 0.0001);
    }

    [TestCase(new double[] {3, 4, 5}, true)]
    [TestCase(new double[] {5, 12, 13}, true)]
    [TestCase(new double[] {Sqrt2, Sqrt2, 2}, true)]
    [TestCase(new double[] {1, 1, 1}, false)]
    [Test]
    public void RightTrianglesAreCorrectlyFound(double[] sides, bool expectedResult)
    {
        var triangle = new Triangle(sides);
        Assert.AreEqual(expectedResult, triangle.IsRightTriangle());
    }
}