public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> table = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++){

            int num = nums[i];

            if(table.Contains(num)){
                return true;
            }
            else{
                table.Add(num);
            }
        }

        return false;
    }
}