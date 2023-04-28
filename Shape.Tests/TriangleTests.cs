using AreaLibrary;

namespace Shape.Tests;

public class TriangleTests
{
    [Fact]
    public void TestInvalidTriangle()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Fact]
    public void TestRightTriangle()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void TestNonRightTriangle()
    {
        Triangle triangle = new Triangle(5, 7, 9);
        Assert.False(triangle.IsRightTriangle());
    }

    [Fact]
    public void TestGetArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double area = triangle.GetArea();
        Assert.Equal(6, area, 2);
    }
}