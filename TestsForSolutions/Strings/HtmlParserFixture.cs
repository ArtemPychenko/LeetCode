using FluentAssertions;
using Strings.Solution.HtmlParser;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class HtmlParserFixture
    {
        [Theory]
        [InlineData("&amp; is an HTML entity but &ambassador; is not.", "& is an HTML entity but &ambassador; is not.")]
        [InlineData("and I quote: &quot;...&quot;", "and I quote: \"...\"")]
        public void EntityParser_WithValidData_ReturnsExpected(string initial, string parsed)
        {
            // Arrange
            var htmlParser = new HtmlParser();

            // Act
            var result = htmlParser.EntityParser(initial);

            // Assert
            result.Should().Be(parsed);
        }
    }
}
