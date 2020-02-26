
using FluentAssertions;
using Math.Solution.AddNumberDigits;
using Xunit;

namespace TestsForSolutions.Math
{
    public class AddNumberDigitsFixture
    {
        [Theory]
        [InlineData(754, 7)]
        [InlineData(1154, 2)]
        [InlineData(23114567, 2)]
        [InlineData(75654, 9)]
        public void AddDigits_WithValidData_ReturnsExpectedResult(int num, int expectedResult)
        {
            // Arrange
            var addNumberDigits = new AddNumberDigits();

            // Act
            var result = addNumberDigits.AddDigits(num);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
