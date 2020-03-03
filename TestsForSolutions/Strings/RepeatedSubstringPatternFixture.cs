using FluentAssertions;
using Strings.Solution.RepeatedSubstringPattern;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class RepeatedSubstringPatternFixture
    {
        [Theory]
        [InlineData("abcabcabcabcx", false)]
        [InlineData("abcabcabcabcxx", false)]
        [InlineData("abcabcabcabcxxx", false)]
        [InlineData("abcabcabcabc", true)]
        public void IsRepeatedSubstringPattern_WithValidDataProvided_ReturnsExpectedResult(string line,
            bool expectedResult)
        {
            // Arrange
            var repeatedSubstringPattern = new RepeatedSubstringPattern();

            // Act
            var result = repeatedSubstringPattern.IsRepeatedSubstringPattern(line);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
