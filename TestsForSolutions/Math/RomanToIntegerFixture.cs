
using FluentAssertions;
using Math.Solution.RomanToInteger;
using Xunit;

namespace TestsForSolutions.Math
{
    public class RomanToIntegerFixture
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt_WithValidData_ReturnsExpectedResult(string s, int expectedResult)
        {
            // Arrange
            var romanToInteger = new RomanToInteger();

            // Act
            var result = romanToInteger.RomanToInt(s);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
