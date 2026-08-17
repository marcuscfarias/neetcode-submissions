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
    public TreeNode InvertTree(TreeNode root) {
        
        if(root != null){

            // Console.WriteLine("Root: {0}, Left: {1}, Right: {2}", root.val, root.left?.val, root.right?.val);
            
            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            // Console.WriteLine("Root: {0}, Left: {1}, Right: {2}", root.val, root.left?.val, root.right?.val);
            
            InvertTree(root.left);
            InvertTree(root.right);
        }

        return root;
    }
}
