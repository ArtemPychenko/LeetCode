using FluentAssertions;
using Trees.Solution;
using Xunit;

namespace TestsForSolutions.Trees
{
    public class BinaryTreeDiameterFixture
    {
        [Fact]
        public void DiameterOfBinaryTree_WithValidData_ReturnsExpected()
        {
            // Arrange
            var tree = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(4)
            };
            tree.left.left = new TreeNode(3);
            //tree.right.left = new TreeNode(3);

            var diameter = new BinaryTreeDiameter();

            var expected = 3;

            // Act
            var result = diameter.DiameterOfBinaryTree(tree);

            // Assert
            result.Should().Be(expected);
        }
    }
}
