
using FluentAssertions;
using Strings.Solution.FizzBuzz;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class FizzBuzzFixture
    {
        [Theory]
        [InlineData(5, new[] {"1", "2", "Fizz", "4", "Buzz"})]
        [InlineData(15,
            new[] {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"})]
        public void IsFizzBuzz_WithValidData_ReturnsExpectedResult(int n, string[] expectedResult)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.IsFizzBuzz(n);

            // Assert
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
