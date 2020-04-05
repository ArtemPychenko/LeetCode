using Arrays.Solution.MaximumSubarray;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class MaximumSubarrayFixture
    {
        [Theory]
        [InlineData(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4}, 6)]
        [InlineData(new[] {-1, -2, -3, -4, 1, 2, 3, 4, 5}, 15)]
        public void MaxSubArrayBrutForce_WithValidData_ReturnsExpected(int[] nums, int maximum)
        {
            // Arrange
            var subArray = new MaximumSubarray();

            // Act
            var result = subArray.MaxSubArrayBrutForce(nums);

            // Assert
            result.Should().Be(maximum);
        }
    }
}
