using FluentAssertions;
using Strings.Solution.ValidParenthesis;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class ValidParenthesisFixture
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("{}", true)]
        [InlineData("{[]}", true)]
        [InlineData("{[()]}", true)]
        [InlineData("(((((((((()))))((((())))))))))", true)]
        [InlineData("(((((((((({}{}{}{}[])))))((((())))))))))", true)]
        [InlineData("(((([](((((({}{}{}{}[])))))((((())))))))))", true)]
        [InlineData("(", false)]
        [InlineData("([", false)]
        [InlineData("([{}", false)]
        [InlineData("([{}]", false)]
        [InlineData("([{})", false)]
        [InlineData("([{)}", false)]
        [InlineData("([{])}", false)]
        public void IsValid_WithProvidedString_ReturnsExpectedResult(string parenthesisString, bool result)
        {
            var validParenthesis = new ValidParenthesis();

            var executionResult = validParenthesis.IsValid(parenthesisString);

            executionResult.Should().Be(result);
        }
    }
}
