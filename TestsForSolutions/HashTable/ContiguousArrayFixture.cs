using FluentAssertions;
using HashTable.Solution.Contiguous_Array;
using Xunit;

namespace TestsForSolutions.HashTable
{
    public class ContiguousArrayFixture
    {
        [Theory]
        [InlineData(new[] {0, 1}, 2)]
        [InlineData(new[] {0, 1, 0}, 2)]
        [InlineData(new[] {0, 0, 1, 0, 0, 0, 1, 1}, 6)]
        public void FindMaxLength_WithValidData_ReturnsExpected(int[] nums, int expected)
        {
            // Arrange
            var arr = new ContiguousArray();

            // Act
            var result = arr.FindMaxLength(nums);

            // Assert
            result.Should().Be(expected);
        }
    }
}
