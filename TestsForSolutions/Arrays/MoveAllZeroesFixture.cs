using Arrays.Solution.MoveAllZeroes;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class MoveAllZeroesFixture
    {
        [Theory]
        [InlineData(new[] {0, 1, 0, 3, 12}, new[] {1, 3, 12, 0, 0})]
        [InlineData(new[] {0, 1, 0, 3, 12, 5, 6, 7, 0, 8}, new[] {1, 3, 12, 5, 6, 7, 8, 0, 0, 0})]
        [InlineData(new[] {0, 1, 0}, new[] {1, 0, 0})]
        public void MoveZeroes_WithValidData_ReturnsExpectedResult(int[] nums, int[] expectedResult)
        {
            // Arrange
            var moveAllZeroes = new MoveAllZeroes();

            // Act
            var result = moveAllZeroes.MoveZeroes(nums);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
