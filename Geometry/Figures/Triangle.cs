namespace Geometry.Figures;

public class Triangle : IFigure
{
    private readonly double SideA;
    private readonly double SideB;
    private readonly double SideC;

    public Triangle(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a ||
            a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("Invalid triangle sides. The sum of any two sides must be greater than the third side");
        }

        SideA = a;
        SideB = b;
        SideC = c;
    }

    public double CalculateArea()
    {
        return (SideA + SideB + SideC) / 2;
    }

    public bool IsTriangleRectangular()
    {
        return Math.Pow(SideA, 2d) + Math.Pow(SideB, 2d) == Math.Pow(SideC, 2d) ||
               Math.Pow(SideA, 2d) + Math.Pow(SideC, 2d) == Math.Pow(SideB, 2d) ||
               Math.Pow(SideC, 2d) + Math.Pow(SideB, 2d) == Math.Pow(SideA, 2d);
    }
}
