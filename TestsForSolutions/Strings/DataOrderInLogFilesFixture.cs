using FluentAssertions;
using Strings.Solution.ReorderDataInLogFiles;
using Xunit;

namespace TestsForSolutions.Strings
{
    public class DataOrderInLogFilesFixture
    {
        [Theory]
        [InlineData(new[] {"dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"},
            new[] {"let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6"})]
        [InlineData(new[] {"a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo", "a2 act car"},
        new[] {"a2 act car", "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7"})]
        [InlineData(new[] {"27 85717 7", "2 y xyr fc", "52 314 99", "d 046099 0", "m azv x f", "7e apw c y", "8 hyyq z p", "6 3272401", "c otdk cl", "8 ksif m u"},
            new[] {"7e apw c y", "m azv x f", "8 hyyq z p", "8 ksif m u", "c otdk cl", "2 y xyr fc", "27 85717 7", "52 314 99", "d 046099 0", "6 3272401"})]
        [InlineData(new[] {"6p tzwmh ige mc", "ns 566543603829", "ubd cujg j d yf", "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249", 
            "0 tllgmf qp znc", "s 1088746413789", "ys0 splqqxoflgx", "uhb rfrwt qzx r", "u lrvmdt ykmox", "ah4 4209164350", "rap 7729 8 125", 
            "4 nivgc qo z i", "apx 814023338 8"}, 
            new[] {"ubd cujg j d yf", "u lrvmdt ykmox", "4 nivgc qo z i", "uhb rfrwt qzx r", "ys0 splqqxoflgx", "0 tllgmf qp znc", 
                "6p tzwmh ige mc", "ns 566543603829", "ha6 1 938 376 5", "3yx 97 666 56 5", "d 84 34353 2249", "s 1088746413789", 
                "ah4 4209164350", "rap 7729 8 125", "apx 814023338 8"})]
        public void ReorderLogFiles_ValidData_ReturnsExpectedResult(string[] unsortedLogs, string[] sortedLogs)
        {
            // Arrange
            var logOrder = new DataOrderInLogFiles();

            // Act
            var result = logOrder.ReorderLogFiles(unsortedLogs);

            // Assert
            result.Should().ContainInOrder(sortedLogs);
        }
    }
}
