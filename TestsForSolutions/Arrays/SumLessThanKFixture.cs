using Arrays.Solution.SumLessThanK;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class SumLessThanKFixture
    {
        [Theory]
        [InlineData(new[] {34, 23, 1, 24, 75, 33, 54, 8}, 60, 58)]
        [InlineData(new[] {10, 20, 30}, 15, -1)]
        [InlineData(new[] {10, 20, 30, 11, 22}, 33, 32)]
        [InlineData(new int[] { }, 15, -1)]
        [InlineData(new[] {10}, 15, -1)]
        public void TwoSumLessThanK_WithValidData_ReturnsExpectedResult(int[] arr, int maximumNumber,
            int expectedResult)
        {
            // Arrange
            var sumLessThanK = new SumLessThanK();

            // Act
            var result = sumLessThanK.TwoSumLessThanK(arr, maximumNumber);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
