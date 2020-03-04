using FluentAssertions;
using HashTable.Solution.BullsAndCows;
using Xunit;

namespace TestsForSolutions.HashTable
{
    public class BullsAndCowsFixture
    {
        [Theory]
        [InlineData("12345", "54321", "1A4B")]
        [InlineData("1", "1", "1A0B")]
        [InlineData("1", "0", "0A0B")]
        [InlineData("1234", "1235", "3A0B")]
        public void GetHint_WithValidData_ReturnsExpectedResult(string secret, string guess, string expectedResult)
        {
            // Arrange
            var bullsAndCows = new BullsAndCows();

            // Act
            var result = bullsAndCows.GetHint(secret, guess);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
