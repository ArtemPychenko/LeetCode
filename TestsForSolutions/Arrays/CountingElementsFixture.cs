using Arrays.Solution.CountingElement;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class CountingElementsFixture
    {
        [Theory]
        [InlineData(new[] {1, 2, 3}, 2)]
        [InlineData(new[] {1, 1, 3, 3, 5, 5, 7, 7}, 0)]
        [InlineData(new[] {1, 3, 2, 3, 5, 0}, 3)]
        [InlineData(new[] {1, 1, 2, 2}, 2)]

        public void CountElements_WithValidData_ReturnsExpected(int[] nums, int expected)
        {
            // Arrange
            var countingElements = new CountingElements();

            // Act
            var result = countingElements.CountElements(nums);

            // Assert
            result.Should().Be(expected);
        }
    }
}
