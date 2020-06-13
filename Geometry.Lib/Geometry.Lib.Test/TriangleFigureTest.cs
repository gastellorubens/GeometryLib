
using Xunit;
using Geometry.Lib.Figures.Flat; 

namespace Geometry.Lib.Test
{
    public class TriangleFigureTest
    {
        [Fact]
        public void CalcTriangleArea()
        {
            var expectedArea = 9.9215674164922145;
            var sideLengths = (4, 5, 6);
            var factArea = new Triangle(sideLengths).Area;
            Assert.True(expectedArea == factArea);
        }
        [Fact]
        public void CheckRectangularTriangle()
        {
            Triangle triangle;
            var successSideLengths = (3, 4, 5);
            var failSideLengths = (3, 4, 6);
            triangle = new Triangle(successSideLengths);
            Assert.True(triangle.IsRectangular);
            triangle = new Triangle(failSideLengths);
            Assert.False(triangle.IsRectangular);
        }
        [Fact]
        public void CalcCircleArea()
        {
            var expectedArea = 314.15927;
            var factArea = new Circle(10).Area;
            Assert.True(expectedArea == factArea);
        }
        [Fact]
        public void CalcPolygonArea()
        {
            var expectedArea = 9.9215674164922145;
            var factArea = Polygon.CalcArea(new double[] { 4, 5, 6 });
            Assert.True(expectedArea == factArea);
        }
    }
}
