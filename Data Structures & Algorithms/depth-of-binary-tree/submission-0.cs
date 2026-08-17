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
    public int MaxDepth(TreeNode root) {
        
        int depth = 0;
        int depthLeft = 0, depthRight = 0;

        if(root != null){

            depthLeft += MaxDepth(root.left) + 1;
            depthRight += MaxDepth(root.right) + 1;

            depth = depthLeft > depthRight ? depthLeft : depthRight;
        }

        return depth;
    }
}
