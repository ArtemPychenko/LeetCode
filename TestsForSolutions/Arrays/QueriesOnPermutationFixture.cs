using Arrays.Solution.QueriesOnPermutation;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class QueriesOnPermutationFixture
    {
        [Theory]
        [InlineData(new[] {3, 1, 2, 1}, 5, new[] {2, 1, 2, 1})]

        public void ProcessQueries_WithValidData_ReturnsExpected(int[] queries, int m, int[] expected)
        {
            // Arrange
            var permutations = new QueriesOnPermutation();

            // Act
            var result = permutations.ProcessQueries(queries, m);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
