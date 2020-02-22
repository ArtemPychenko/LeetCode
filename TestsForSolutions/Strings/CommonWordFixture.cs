using FluentAssertions;
using Strings.Solution.CommonWord;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class CommonWordFixture
    {
        [Theory]
        [InlineData("Hello, hello, good morning; why good! Do you heLlo, you", new []{ "you", "good" }, "hello")]
        [InlineData("Hello, hello, good morning; why good! Do you heLlo, you", new[] { "you" }, "hello")]
        [InlineData("Hello, hello, good morning; why good! Do you heLlo, you good", new[] { "hello" }, "good")]
        [InlineData("Hello, hello, good morning; why good! Do you heLlo, you", new[] { "hello", "good" }, "you")]
        [InlineData("Hello, hello, good morning; why good! Do you do heLlo, you", new[] { "you", "good", "hello" }, "do")]
        [InlineData("Hello", new string[] {} , "hello")]
        [InlineData("q, r, t; t' r' q; t;", new [] {"q"} , "t")]
        public void MostCommonWord_WithProvidedString_ReturnsExpectedResult(string paragraph, string[] banned, string mostCommonWord)
        {
            // Arrange
            var commonWord = new CommonWord();

            // Act
            var result = commonWord.MostCommonWord(paragraph, banned);

            // Assert
            result.Should().Be(mostCommonWord);
        }
    }
}
