namespace AreaLibrary;

public class Triangle : IFigure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException("Invalid triangle sides.");
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        
        return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
    }

    public double GetArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
    
    private bool IsValidTriangle(double side1, double side2, double side3)
    {
        if (side1 < 0 || side2 < 0 || side3 < 0) 
            return false;

        return (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1);
    }
}