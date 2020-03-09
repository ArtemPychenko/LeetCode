using FluentAssertions;
using Strings.Solution.FirstUniqueCharInAString;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class FirstUniqueCharInAStringFixture
    {
        [Theory]
        [InlineData("llhhtteeee", -1)]
        [InlineData("hello", 0)]
        [InlineData("lolohot", 4)]
        public void FirstUniqChar_WithValidData_ReturnsExpectedResult(string s, int expected)
        {
            // Arrange
            var uniqueChar = new FirstUniqueCharInAString();

            // Act
            var result = uniqueChar.FirstUniqChar(s);

            // Assert
            result.Should().Be(expected);
        }
    }
}
