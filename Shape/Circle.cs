namespace AreaLibrary;

public class Circle : IFigure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        if (radius < 0) throw new ArgumentOutOfRangeException(nameof(radius));
        
        Radius = radius;
    }
    
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}