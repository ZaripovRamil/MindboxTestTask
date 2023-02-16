using MindboxTestTask;
using NUnit.Framework;

namespace FigureClassTests;

[TestFixture]
public class CircleTests
{
    private const double Pi = 3.141592653589793;
    private readonly Action<double> _creatingCircle = radius =>
    {
        var circle= new Circle(radius);
    };
    
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-1.5)]
    [Test]
    public void InvalidRadius_ThrowsException(double radius)
    {
        Assert.Throws<ArgumentException>(()=>_creatingCircle(radius));
    }
    
    [TestCase(1, Pi)]
    [TestCase(2, 4*Pi)]
    [Test]
    public void AreaCorrectlyCounted(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        Assert.AreEqual(expectedArea,circle.Area, 0.001);
    }
}