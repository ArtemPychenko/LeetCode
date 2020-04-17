using FluentAssertions;
using Strings.Solution.ValidParenthesisString;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class ValidParenthesisStringFixture
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("(*)", true)]
        [InlineData("(*))", true)]
        public void CheckValidString_WithValidData_ReturnsExpected(string s, bool expected)
        {
            // Arrange
            var validParenthesis = new ValidParenthesisString();

            // Act
            var result = validParenthesis.CheckValidString(s);

            // Assert
            result.Should().Be(expected);
        }
    }
}
