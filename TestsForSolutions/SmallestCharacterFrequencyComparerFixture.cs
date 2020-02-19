using EasyLevel.Strings.Solution.SmallestCharacterFrequencyComparer;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions
{
    public class SmallestCharacterFrequencyComparerFixture
    {
        [Theory]
        [InlineData(new[] {"bbb", "cc"}, new[] {"a", "aa", "aaa", "aaaa"}, new[] {1, 2})]
        [InlineData(new[] {"htteddddd"}, new[] {"zaaaz", "zaaaz" }, new[] {0})]
        [InlineData(new[] {"c"}, new[] {"zaaaz"}, new[] {1})]
        [InlineData(new[] {"cbdrrrr"}, new[] {"zaaaz"}, new[] {1})]
        [InlineData(new[] {"cbd"}, new[] {"zaaaz"}, new[] {1})]
        [InlineData(new[] {"cbd", "cbfbbd" , "cbd" }, new[] {"zaaaz", "dddud", "juriifedew"}, new[] {2, 1, 2})]
        public void NumSmallerByFrequency_WithProvidedData_ReturnsExpectedResult(
            string[] queries, 
            string[] words,
            int[] expectedNumbers)
        {
            // Arrange
            var smallestCharacterFrequencyComparer = new SmallestCharacterFrequencyComparer();

            // Act
            var result = smallestCharacterFrequencyComparer.NumSmallerByFrequency(queries, words);

            // Assert
            result.Should().BeEquivalentTo(expectedNumbers);
        }
    }
}
