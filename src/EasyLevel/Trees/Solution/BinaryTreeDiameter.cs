
using System;

namespace Trees.Solution
{
    public class BinaryTreeDiameter
    {
        private int _diameter;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var temp = GetHeight(root);

            return _diameter - 1;
        }

        private int GetHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int maxDepthOfLeftSubTree = GetHeight(root.left);
            int maxDepthOfRightSubTree = GetHeight(root.right);
            _diameter = Math.Max(_diameter, maxDepthOfLeftSubTree + maxDepthOfRightSubTree + 1);

            return Math.Max(maxDepthOfLeftSubTree, maxDepthOfRightSubTree) + 1;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }
}
