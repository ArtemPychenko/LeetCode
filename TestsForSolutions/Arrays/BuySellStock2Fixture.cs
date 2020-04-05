using Arrays.Solution.BuySellStock2;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class BuySellStock2Fixture
    {
        [Theory]
        [InlineData(new[] {7, 1, 5, 3, 6, 4}, 7)]
        [InlineData(new[] {1, 2, 3, 4, 5}, 4)]
        [InlineData(new[] {7, 6, 4, 3, 1}, 0)]
        [InlineData(new[] {2, 1, 2, 0, 1}, 2)]
        public void MaxProfit_WithValidData_ReturnsExpected(int[] prices, int maxProfit)
        {
            // Arrange
            var buySellStock = new BuySellStock2();

            // Act
            var result = buySellStock.MaxProfit(prices);

            // Assert
            result.Should().Be(maxProfit);
        }
    }
}
