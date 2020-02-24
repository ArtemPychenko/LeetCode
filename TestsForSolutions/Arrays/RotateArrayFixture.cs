
using Arrays.Solution.RotateArray;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class RotateArrayFixture
    {
        [Theory]
        [InlineData(new[] {1, 2, 4, 7, 9}, 4, new[] {2, 4, 7, 9, 1})]
        [InlineData(new[] {1, 2, 45, -7, 11, 55, 74}, 2, new[] {55, 74, 1, 2, 45, -7, 11})]
        [InlineData(new[] {1, 2, 4}, 4, new[] {4, 1, 2})]
        [InlineData(new[] {1, 2, 4, 7, 9}, 0, new[] {1, 2, 4, 7, 9})]
        [InlineData(new[] {1, 2, 3, 4, 5, 6, 7}, 3, new[] {5, 6, 7, 1, 2, 3, 4})]
        public void Rotate_WithValidData_ReturnsExpectedResult(int[] nums, int k, int[] expectedResult)
        {
            // Arrange
            var rotateArray = new RotateArray();

            // Act
            var result = rotateArray.Rotate(nums, k);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
