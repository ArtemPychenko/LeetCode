
using FluentAssertions;
using Strings.Solution.LicenseKeyFormatting;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class LicenseKeyFormattingFixture
    {
        [Theory]
        [InlineData("5F3Z-2e-9-w", 4, "5F3Z-2E9W")]
        [InlineData("5F-3Z", 4, "5F3Z")]
        [InlineData("2-5g-3-J", 2, "2-5G-3J")]
        public void FormatLicenseKey_WithValidData_ReturnsExpectedResult(string s, int k, string expectedResult)
        {
            // Arrange
            var licenseKeyFormatting = new LicenseKeyFormatting();

            // Act
            var result = licenseKeyFormatting.FormatLicenseKey(s, k);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
