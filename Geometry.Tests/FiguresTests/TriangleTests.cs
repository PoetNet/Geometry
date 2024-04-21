using Geometry.Figures;

namespace Geometry.Tests.FiguresTests;

public class TriangleTests
{
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(3, 4, 5)]
    [InlineData(7, 7, 9)]
    public void CreateTriangle_RightValues_SuccessCreated(double a, double b, double c)
    {
        //Act & Assert
        try
        {
            Triangle testFigure = new(a, b, c);
        }
        catch (Exception)
        {
            Assert.Fail();
        }
    }

    [Theory]
    [InlineData(1, 1, 3)]
    [InlineData(2, 3, 6)]
    [InlineData(4, 5, 10)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 1, 0)]
    public void CreateTriangle_WrongValues_ThrowsException(double a, double b, double c)
    {
        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Theory]
    [InlineData(1, 1, 1, 1.5)]
    [InlineData(3, 4, 5, 6)]
    [InlineData(7, 7, 10, 12)]
    public void CalculateArea_RightValues_SuccessCalculated(double a, double b, double c, double expectedArea)
    {
        //Arrange
        Triangle testFigure = new(a, b, c);

        //Act
        double areaResult = testFigure.CalculateArea();

        //Assert
        Assert.Equal(expectedArea, areaResult);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(8, 15, 17, true)]
    [InlineData(1, 1, 1, false)]
    [InlineData(3, 5, 6, false)]
    [InlineData(7, 7, 9, false)]
    public void IsTriangleRectangular_RectangularTriangleSides_RightCalculated(double a, double b, double c, bool expectedResult)
    {
        //Arrange
        Triangle testFigure = new(a, b, c);

        //Act
        bool result = testFigure.IsTriangleRectangular();

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
