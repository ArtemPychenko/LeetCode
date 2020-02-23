using Arrays.Solution.DecompressRunLengthEncodedList;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class DecompressRunLengthEncodedListFixture
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, new[] {2, 4, 4, 4})]
        [InlineData(new[] {1, 2}, new[] {2})]
        [InlineData(new[] {1, 2, 5, 42, 3, 8}, new[] {2, 42, 42, 42, 42, 42, 8, 8, 8})]
        public void DecompressRLEList_WithValidData_ReturnsExpectedResult(int[] nums, int[] expectedArray)
        {
            // Arrange
            var decompressRLEList = new DecompressRunLengthEncodedList();

            // Act
            var result = decompressRLEList.DecompressRLEList(nums);

            // Assert
            result.Should().BeEquivalentTo(expectedArray);
        }
    }
}
