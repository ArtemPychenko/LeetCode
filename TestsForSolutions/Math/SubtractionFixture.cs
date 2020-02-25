
using System.Runtime.InteropServices.ComTypes;
using FluentAssertions;
using Math.Solution.Subtraction;
using Xunit;

namespace TestsForSolutions.Math
{
    public class SubtractionFixture
    {
        [Theory]
        [InlineData(123, 0)]
        [InlineData(74885, 8928)]
        [InlineData(12, -1)]
        [InlineData(0, 0)]
        public void SubtractProductAndSum_WithValidData_ReturnsExpectedResult(int n, int expectedResult)
        {
            // Arrange
            var subtract = new Subtraction();

            // Act
            var result = subtract.SubtractProductAndSum(n);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
