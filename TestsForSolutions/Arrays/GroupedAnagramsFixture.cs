using System.Collections.Generic;
using Arrays.Solution.GroupedAnagrams;
using FluentAssertions;
using Xunit;

namespace TestsForSolutions.Arrays
{
    public class GroupedAnagramsFixture
    {
        [Fact]
        public void GroupAnagrams_WithValidData_ReturnsExpected()
        {
            // Arrange
            var init = new [] {"ate", "","eat", "", ""};
            var expected = new List<IList<string>>
            {
                new List<string>()
                {
                    "ate", "eat"
                },
                new List<string>()
                {
                    "", "", ""
                }
            };

            var groupedAnagrams = new GroupedAnagrams();

            // Act
            var result = groupedAnagrams.GroupAnagrams(init);

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

    }
}
