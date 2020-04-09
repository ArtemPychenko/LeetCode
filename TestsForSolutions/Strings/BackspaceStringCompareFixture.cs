using FluentAssertions;
using Strings.Solution.BackspaceStringCompare;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class BackspaceStringCompareFixture
    {
        [Theory]
        [InlineData("ab#c", "ad#c", true)]
        [InlineData("ab##", "c#d#", true)]
        [InlineData("a##c", "#a#c", true)]
        [InlineData("a#c", "b", false)]
        public void BackspaceCompare_WithValidData_ReturnsExpected(string S, string T, bool expected)
        {
            // Arrange
            var stringComparer = new BackspaceStringCompare();

            // Act
            var result = stringComparer.BackspaceCompare(S, T);

            // Assert
            result.Should().Be(expected);
        }
    }
}
