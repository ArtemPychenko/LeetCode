using FluentAssertions;
using HashTable.Solution.AlienDictionary;
using Xunit;

namespace TestsForSolutions.HashTable
{
    public class AlienDictionaryFixture
    {
        [Theory]
        [InlineData(new[] {"hello", "leetcode"}, "hlabcdefgijkmnopqrstuvwxyz", true)]
        public void IsAlienSorted_WithValidData_ReturnsExpectedResult(string[] words, string order, bool expected)
        {
            // Arrange
            var alienDictionary = new AlienDictionary();

            // Act
            var result = alienDictionary.IsAlienSorted(words, order);

            // Assert
            result.Should().Be(expected);
        }
    }
}
