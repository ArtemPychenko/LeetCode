using FluentAssertions;
using Strings.Solution.GoatLatin;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class GoatLatinFixture
    {
        [Theory]
        [InlineData("I am", "Imaa ammaaa")]
        [InlineData("Hello World people", "elloHmaa orldWmaaa eoplepmaaaa")]
        public void ToGoatString_WithValidData_ReturnsExpectedResult(string s, string expected)
        {
            // Arrange
            var goatString = new GoalLatin();

            // Act
            var result = goatString.ToGoatLatin(s);

            // Assert
            result.Should().Be(expected);
        }
    }
}
