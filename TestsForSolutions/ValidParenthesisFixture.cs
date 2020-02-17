using EasyLevel.Strings.Solution.ValidParenthesis;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions
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
        public void IsValid_WithProvidedString_ReturnsProperResult(string parenthesisString, bool result)
        {
            var validParenthesis = new ValidParenthesis();

            var executionResult = validParenthesis.IsValid(parenthesisString);

            executionResult.Should().Be(result);
        }
    }
}
