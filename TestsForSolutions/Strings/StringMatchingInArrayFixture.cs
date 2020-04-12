using FluentAssertions;
using Strings.Solution.StringMatchingInArray;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class StringMatchingInArrayFixture
    {
        [Theory]
        [InlineData(new[] {"mass", "as", "hero", "superhero"}, new[] {"as", "hero"})]
        public void StringMatching_WithValidData_ReturnsExpected(string[] words, string[] expected)
        {
            // Arrange
            var matching = new StringMatchingInArray();

            // Act
            var result = matching.StringMatching(words);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
