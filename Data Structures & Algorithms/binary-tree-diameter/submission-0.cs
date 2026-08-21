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
        
        // Para cada nodo é necessário somar a maior profundidade
        // da esquerda e da direita. Maior profundidade podemos entender
        // como a altura do nodo.
        // Por exemplo: Há esquerda de 1 a altura é 0. Há direita é 3.
        // Ou seja, 3 como resultado.
        // Por exemplo: Há esquerda de 5 a altura é 0. Há direita é 0.
        // Ou seja, 0 como resultado.
        // Por exemplo: Há esquerda de 2 a altura é 2. Há direita é 1.
        // Ou seja, 3 como resultado.
        // Com base nisso, precisamos declarar uma variável global diâmetro
        // para ir comparando cada nodo.

        int diameter = 0;
        BinaryTreeHeightOffsetOfOne(root, ref diameter);

        return diameter;
    }

    //starting from 1
    private int BinaryTreeHeightOffsetOfOne(TreeNode root, ref int diameter){

        if(root == null){
            return 0;
        }

        // check each diameter
        int left = BinaryTreeHeightOffsetOfOne(root.left, ref diameter);
        int right = BinaryTreeHeightOffsetOfOne(root.right, ref diameter);
        int height = 1 + Math.Max(left, right);
        
        // save in the global variable
        diameter = Math.Max(diameter, left + right);

        Console.WriteLine("Root: {0}, Height: {1}, Left: {2}, Right: {3}, Diameter: {4}", root.val, height, left, right, diameter);

        return height;
    }
}
