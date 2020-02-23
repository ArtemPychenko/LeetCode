using System.Collections.Generic;
using Arrays.Solution.PascalsTriangle;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class PascalsTriangleFixture
    {
        [Fact]
        public void Generate_WithValidData_ReturnsExpectedResult()
        {
            // Arrange
            var numRows = 5;
            var expectedResult = new List<IList<int>>()
            {
                new List<int>()
                {
                    1
                },
                new List<int>()
                {
                    1, 1
                },
                new List<int>()
                {
                    1, 2, 1
                },
                new List<int>()
                {
                    1, 3, 3, 1
                },
                new List<int>()
                {
                    1, 4, 6, 4, 1
                }
            };
            var pascalTriangle = new PascalsTriangle();

            // Act
            var result = pascalTriangle.Generate(numRows);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
