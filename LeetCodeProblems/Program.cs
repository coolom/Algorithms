using System;

namespace LeetCodeProblems
{
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = new TreeNode(3);
            node.left = new TreeNode(9);
            node.right = new TreeNode(20);
            node.left.left = null;
            node.left.right = null;
            node.right.left = new TreeNode(15);
            node.right.right = new TreeNode(7);

            int result = MaxDepth(node);
            Console.WriteLine(result);

        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0; 

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return 1 + Math.Max(left, right);
        }
    }
}
