public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] returnedArray = new int[] { 0, 0 };

        for(int i = 0; i < nums.Length - 1; i++){
            
            int iValue = nums[i];
            // Console.WriteLine();
            // Console.WriteLine("iValue: {0}", iValue);
            // Console.Write("jValue: ");
            
            for(int j = i + 1; j < nums.Length; j++){

                int jValue = nums[j];
                // Console.Write("{0}, ", jValue);

                if(iValue + jValue == target){
                    
                    returnedArray = new int[] { i, j };
                    return returnedArray;
                }
            }
        }

        return returnedArray;
    }
}
