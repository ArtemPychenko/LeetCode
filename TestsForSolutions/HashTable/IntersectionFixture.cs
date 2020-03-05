using FluentAssertions;
using HashTable.Solution.IntersectionOfTwoArrays;
using Xunit;

namespace TestsForSolutions.HashTable
{
    public class IntersectionFixture
    {
        [Theory]
        [InlineData(new[] {1, 2, 2, 1}, new[] {2, 2}, new[] {2})]
        [InlineData(new[] {4, 9, 5}, new[] {9, 4, 9, 8, 4}, new[] {9, 4})]
        public void Intersection_WithValidData_ReturnsExpectedResult(int[] nums1, int[] nums2, int[] expected)
        {
            // Arrange
            var intersection = new IntersectionOfTwoArrays();

            // Act
            var result = intersection.Intersection(nums1, nums2);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
