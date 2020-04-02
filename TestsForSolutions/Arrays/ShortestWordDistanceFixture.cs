using Arrays.Solution.ShortestWordDistance;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class ShortestWordDistanceFixture
    {
        [Theory]
        [InlineData(new[] {"practice", "makes", "perfect", "coding", "makes"}, "coding", "practice", 3)]
        [InlineData(new[] {"practice", "makes", "perfect", "coding", "makes"}, "makes", "coding", 1)]
        public void ShortestDistance_WithValidData_ReturnsExpected(string[] words, string word1, string word2,
            int difference)
        {
            // Arrange
            var distance = new ShortestWordDistance();

            // Act
            var result = distance.ShortestDistance(words, word1, word2);

            // Assert
            result.Should().Be(difference);
        }
    }
}
