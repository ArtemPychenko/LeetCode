using Arrays.Solution.HighestFive;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class HighestFiveFixture
    {
        // Arrange
        private int[][] _initialArray = new int[][]
        {
            new [] {1, 91},
            new [] {1, 92},
            new [] {2, 93},
            new [] {2, 97},
            new [] {1, 60},
            new [] {2, 77},
            new [] {1, 65},
            new [] {1, 87},
            new [] {1, 100},
            new [] {2, 100},
            new [] {2, 76}
        };

        private int[][] _expectedResult = new int[][]
        {
            new [] {1, 87},
            new [] {2, 88}
        };

        [Fact]
        public void HighFive_WithValidData_ReturnsExpectedResult()
        {
            // Arrange
            var highestFive = new HighestFive();

            // Act
            var result = highestFive.HighFive(_initialArray);

            // Assert
            result.Should().BeEquivalentTo(_expectedResult);
        }
    }
}
