
using Arrays.Solution.PlusOne;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class PlusOneFixture
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, new[] {1, 2, 3, 5})]
        [InlineData(new[] {1, 2, 3, 9}, new[] {1, 2, 4, 0})]
        [InlineData(new[] {9}, new[] {1, 0})]
        public void AddOne_WithValidData_ReturnsExpectedResult(int[] digits, int[] expected)
        {
            // Arrange
            var plusOne = new PlusOne();

            // Act
            var result = plusOne.AddOne(digits);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
