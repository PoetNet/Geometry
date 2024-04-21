using Geometry.Figures;

namespace Geometry.Tests.FiguresTests;

public class CircleTests
{
    [Fact]
    public void CreateCircle_PositiveValueRadius_SuccessCreated()
    {
        //Act & Assert
        try
        {
            Circle testFigure = new(1);
        }
        catch (Exception)
        {
            Assert.Fail();
        }
    }

    [Fact]
    public void CreateCircle_ZeroOrNegativeValueRadius_ThrowsException()
    {
        //Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(-1));
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Theory]
    [InlineData(2, 4 * Math.PI)]
    [InlineData(4, 16 * Math.PI)]
    [InlineData(8, 64 * Math.PI)]
    public void CalculateArea_ValidRadius_SuccessCalculated(double radius, double expectedArea)
    {
        //Arrange
        Circle testFigure = new(radius);

        //Act
        double areaResult = testFigure.CalculateArea();

        //Assert
        Assert.Equal(expectedArea, areaResult);
    }
}
