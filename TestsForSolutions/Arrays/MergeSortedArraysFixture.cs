using Arrays.Solution.MergeSortedArrays;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class MergeSortedArraysFixture
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 0, 0, 0}, 3, new[] {2, 5, 6}, 3, new[] {1, 2, 2, 3, 5, 6})]
        public void Merge_WithValidData_ReturnsExpectedResult(int[] nums1, int m, int[] nums2, int n,
            int[] expectedArray)
        {
            // Arrange
            var mergeSortedArrays = new MergeSortedArrays();

            // Act
            var result = mergeSortedArrays.Merge(nums1, m, nums2, n);

            // Assert
            result.Should().BeEquivalentTo(expectedArray);
        }
    }
}
