using Arrays.Solution.LastStoneWeight;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class LastStoneWeightFixture
    {
        [Theory]
        [InlineData(new[] {2, 7, 4, 1, 8, 1}, 1)]
        [InlineData(new[] {2, 7, 4, 1, 16}, 2)]
        public void GetLastStoneWeight_WithValidData_ReturnsExpected(int[] stones, int heaviest)
        {
            // Arrange
            var stoneWeight = new LastStoneWeight();

            // Act
            var result = stoneWeight.GetLastStoneWeight(stones);

            // Assert
            result.Should().Be(heaviest);
        }
    }
}
