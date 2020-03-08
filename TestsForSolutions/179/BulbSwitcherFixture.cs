using _179.BulbSwitcher;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions._179
{
    public class BulbSwitcherFixture
    {
        [Theory]
        [InlineData(new[] {2, 1, 3, 5, 4}, 3)]
        [InlineData(new[] {2, 1, 4, 3, 6, 5}, 3)]
        [InlineData(new[] {4, 1, 2, 3}, 1)]
        [InlineData(new[] {1, 2, 3, 4, 5, 6}, 6)]
        [InlineData(new[] {4}, 0)]
        [InlineData(new[] {4, 5}, 0)]
        public void NumTimesAllBlue_WithValidData_ReturnsExpected(int[] light, int expected)
        {
            // Arrange
            var bulbSwitcher = new BulbSwitcher();

            // Act
            var result = bulbSwitcher.NumTimesAllBlue(light);

            // Assert
            result.Should().Be(expected);
        }
    }
}
