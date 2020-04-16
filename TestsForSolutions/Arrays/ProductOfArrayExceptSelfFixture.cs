using Arrays.Solution.ProductOfArrayExceptSelf;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class ProductOfArrayExceptSelfFixture
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, new[] {24, 12, 8, 6})]
        [InlineData(new[] {3, 6, 15, 4}, new[] {360, 180, 72, 270})]
        [InlineData(new[] {3, 7}, new[] {7, 3})]
        public void ProductExceptSelf_WithValidData_ReturnsExpected(int[] nums, int[] expected)
        {
            // Arrange
            var product = new ProductOfArrayExceptSelf();

            // Act
            var result = product.ProductExceptSelf(nums);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
