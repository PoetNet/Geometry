using Geometry.Figures;

namespace Geometry;

// A class providing functionality  computing the total area of a collection
// of shapes without prior knowledge of their types at compile-time.
public static class GeneralGeometry
{
    public static double CalculateTotalArea(IEnumerable<IFigure> figures)
    {
        double totalArea = 0;
        foreach (var figure in figures)
        {
            totalArea += figure.CalculateArea();
        }

        return totalArea;
    }
}
