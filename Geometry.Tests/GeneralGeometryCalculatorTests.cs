using Geometry.Figures;

namespace Geometry.Tests;

public class GeneralGeometryTests
{
    [Theory]
    [InlineData(2, 1, 1, 1,  (4  * Math.PI) + 1.5)]
    [InlineData(4, 3, 4, 5,  (16 * Math.PI) + 6)]
    [InlineData(8, 7, 7, 10, (64 * Math.PI) + 12)]
    public void CalculateTotalArea_ValidValues_SuccessCalculated(double radius, double a, double b, double c, double expectedResult)
    {
        //Arrange
        Circle testCircle = new(radius);
        Triangle testTriangle = new(a, b, c);

        var figures = new List<IFigure>() { testCircle, testTriangle };

        //Act
        double totalAreaResult = GeneralGeometry.CalculateTotalArea(figures);

        //Assert
        Assert.Equal(expectedResult, totalAreaResult);
    }
}
