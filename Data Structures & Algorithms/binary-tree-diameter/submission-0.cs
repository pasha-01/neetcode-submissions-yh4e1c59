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

// public class Solution {
//     public int DiameterOfBinaryTree(TreeNode root) {
        
//     }
// }


public class Solution
{
    private int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        Height(root);
        return diameter;
    }

    private int Height(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = Height(node.left);
        int right = Height(node.right);

        // Update diameter
        diameter = Math.Max(diameter, left + right);

        // Return height
        return 1 + Math.Max(left, right);
    }
}
