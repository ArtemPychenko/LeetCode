using FluentAssertions;
using Math.Solution.RectangleOverlap;
using Xunit;

namespace TestsForSolutions.Math
{
    public class RectangleOverlapFixture
    {
        [Theory]
        [InlineData(new[] {0, 0, 2, 2}, new[] {1, 1, 3, 3}, true)]
        [InlineData(new[] {0, 0, 1, 1}, new[] {1, 0, 2, 1}, false)]
        [InlineData(new[] {0, 0, 1, 1}, new[] {0, 0, 1, 1}, true)]
        [InlineData(new[] {8, 20, 12, 20}, new[] {14, 2, 19, 11}, false)]
        [InlineData(new[] {11, 12, 13, 13}, new[] {17, 1, 17, 19}, false)]
        public void IsRectangleOverlap_WithValidData_ReturnedExpectedResult(int[] rec1, int[] rec2, bool expectedResult)
        {
            // Arrange
            var rectangleOverlap = new RectangleOverlap();

            // Act
            var result = rectangleOverlap.IsRectangleOverlap(rec1, rec2);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
