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
    public int DiameterOfBinaryTree(TreeNode root) {
        
        int diameter = 0;

        BinaryTreeHeight(root, ref diameter);

        return diameter;
    }


    private int BinaryTreeHeight(TreeNode root, ref int diameter){

        if(root == null){
            return 0;
        }

        int left = root.left == null ? 0 : 1 + BinaryTreeHeight(root.left, ref diameter);
        int right = root.right == null ? 0 : 1 + BinaryTreeHeight(root.right, ref diameter);

        int height = Math.Max(left, right);
        diameter = Math.Max(diameter, left + right);

        Console.WriteLine("Root: {0}, Height: {1}, Left: {2}, Right: {3}, Diameter: {4}", root.val, height, left, right, diameter);

        return height;
    }
}
