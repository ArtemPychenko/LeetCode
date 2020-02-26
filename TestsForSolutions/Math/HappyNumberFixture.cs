
using FluentAssertions;
using Math.Solution.HappyNumber;
using Xunit;

namespace TestsForSolutions.Math
{
    public class HappyNumberFixture
    {
        [Theory]
        [InlineData(19, true)]
        [InlineData(116, false)]
        public void IsHappy_WithValidData_ReturnsExpectedResult(int number, bool expectedResult)
        {
            // Arrange
            var happyNumber = new HappyNumber();

            // Act
            var result = happyNumber.IsHappy(number);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
