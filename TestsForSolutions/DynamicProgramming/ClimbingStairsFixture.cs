using DynamicProgramming.Solution.ClimbingStairs;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.DynamicProgramming
{
    public class ClimbingStairsFixture
    {
        [Theory]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        [InlineData(15, 987)]
        [InlineData(10, 89)]
        public void ClimbStairs_WithValidData_ReturnsExpectedResult(int n, int expected)
        {
            // Arrange
            var climbing = new ClimbingStairs();

            // Act
            var result = climbing.ClimbStairs(n);

            // Assert
            result.Should().Be(expected);
        }
    }
}
