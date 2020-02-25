
using Arrays.Solution.RemoveDuplicatesFromArray;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class RemoveDuplicatesFromArrayFixture
    {
        [Theory]
        [InlineData(new[] {0, 1, 1, 3, 6, 6, 7}, 5)]
        [InlineData(new[] {0, 1}, 2)]
        [InlineData(new[] {1, 1, 1, 3, 5, 5, 7, 7}, 4)]
        [InlineData(new[] {0, 1, 1, 1, 1, 6, 6}, 3)]
        [InlineData(new[] {1, 1, 1, 1, 1, 1, 1}, 1)]
        [InlineData(new[] {1}, 1)]
        [InlineData(new int[] {}, 0)]
        public void RemoveDuplicates_WithValidData_ReturnsExpectedResult(int[] nums, int expectedResult)
        {
            // Arrange
            var removeDuplicates = new RemoveDuplicatesFromArray();

            // Act
            var result = removeDuplicates.RemoveDuplicates(nums);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
