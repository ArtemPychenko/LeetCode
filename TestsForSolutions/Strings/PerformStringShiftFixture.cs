using FluentAssertions;
using Strings.Solution.PerformStringShift;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class PerformStringShiftFixture
    {
        [Fact]
        public void ShiftString_WithValidData_ReturnsExpected()
        {
            // Arrange
            string s = "abcdefg";
            int[][] shift =
            {
                new[]
                {
                    1, 1
                },
                new[]
                {
                    1, 1
                },
                new[]
                {
                    0, 2
                },
                new[]
                {
                    1, 3
                }
            };

            string expected = "efgabcd";

            var stringShift = new PerformStringShift();

            // Act
            var result = stringShift.StringShift(s, shift);

            // Assert
            result.Should().Be(expected);
        }
    }
}
