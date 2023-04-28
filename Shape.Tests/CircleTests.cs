using AreaLibrary;

namespace Shape.Tests;

public class CircleTests
{
    [Fact]
    public void TestInvalidRadius()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }

    [Fact]
    public void TestValidRadius()
    {
        Circle circle = new Circle(5);
        Assert.Equal(5, circle.Radius);
    }

    [Fact]
    public void TestGetArea()
    {
        Circle circle = new Circle(5);
        double area = circle.GetArea();
        Assert.Equal(78.54, area, 0.01);
    }
}