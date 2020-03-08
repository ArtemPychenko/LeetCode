using _179.StringWithOddCounts;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions._179
{
    public class StringWithOddNumbersFixture
    {
        [Theory]
        [InlineData(4, "abcd")]
        [InlineData(2, "ab")]
        [InlineData(7, "abcdefg")]
        [InlineData(35, "cdefghijklmnopqrstuvwxyzaaaaaaaaaaa")]
        [InlineData(100, "bcdefghijklmnopqrstuvwxyzaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
        [InlineData(1, "a")]
        [InlineData(0, "")]
        public void GenerateTheString_WithValidData_ReturnsExpectedResult(int n, string expected)
        {
            // Arrange
            var stringWithOddNumbers = new StringWithOddCounts();

            // Act
            var result = stringWithOddNumbers.GenerateTheString(n);

            // Assert
            result.Should().Be(expected);
        }
    }
}
