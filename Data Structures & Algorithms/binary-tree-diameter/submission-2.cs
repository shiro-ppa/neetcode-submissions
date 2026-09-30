/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Height(root);
        return max;
    }
    private int Height(TreeNode root) {
        if (root == null) return 0;
        max = Math.Max(Height(root.left) + Height(root.right), max);
        return Math.Max(Height(root.left), Height(root.right)) + 1;
    }
}
