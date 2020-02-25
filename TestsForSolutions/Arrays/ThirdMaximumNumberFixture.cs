
using Arrays.Solution.ThirdMaximumNumber;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class ThirdMaximumNumberFixture
    {
        [Theory]
        [InlineData(new[] {3, 2, 7, 98, 5}, 5)]
        [InlineData(new[] {3}, 3)]
        [InlineData(new[] {3, 7}, 7)]
        [InlineData(new[] {6, 6, 6, 6, 6}, 6)]
        [InlineData(new[] {4, 90, 90, 90}, 90)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 1, 1, 2 }, 2)]
        public void ThirdMax_WithValidData_ReturnsExpectedResult(int[] nums, int expectedResult)
        {
            // Arrange
            var thirdMaxNumber = new ThirdMaximumNumber();

            // Act
            var result = thirdMaxNumber.ThirdMax(nums);

            // Assert
            result.Should().Be(expectedResult);
        }

    }
}
