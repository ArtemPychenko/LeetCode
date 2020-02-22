using Arrays.Solution.MaximumProfit;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class MaximumProfitFixture
    {
        [Theory]
        [InlineData(new[] {7, 1, 4, 3, 5, 1}, 4)]
        [InlineData(new[] {7, 1, 5, 3, 6, 4}, 5)]
        [InlineData(new[] {7, 6, 4, 3, 1}, 0)]
        [InlineData(new[] {7, 6}, 0)]
        [InlineData(new[] {1, 2, 3, 4, 5, 86, 85}, 85)]
        [InlineData(new[] {3, 7, 5, 11, 8}, 8)]
        [InlineData(new int[] {}, 0)]
        [InlineData(new[] {3}, 0)]
        [InlineData(new[] {3, 2, 6, 5, 0, 3}, 4)]
        public void MaxProfit_WithValidData_ReturnsExpectedResult(int[] prices, int expectedResult)
        {
            // Arrange
            var maximumProfit = new MaximumProfit();

            // Act
            var result = maximumProfit.MaxProfit(prices);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
