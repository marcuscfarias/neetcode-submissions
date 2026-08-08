public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){

            int numValue = nums[i];
            int dif = target - numValue;

            Console.WriteLine("numValue: {0}, dif: {1}", numValue, dif);

            if(dic.ContainsKey(dif))
            {
                return new int[] {dic[dif], i};
            }
            else
            {
                dic.Add(numValue, i);
            }
        }



        int[] returnedArray = new int[] { 0, 0 };

        // for(int i = 0; i < nums.Length - 1; i++){
            
        //     int iValue = nums[i];
        //     // Console.WriteLine();
        //     // Console.WriteLine("iValue: {0}", iValue);
        //     // Console.Write("jValue: ");
            
        //     for(int j = i + 1; j < nums.Length; j++){

        //         int jValue = nums[j];
        //         // Console.Write("{0}, ", jValue);

        //         if(iValue + jValue == target){
                    
        //             returnedArray = new int[] { i, j };
        //             return returnedArray;
        //         }
        //     }
        // }

        return returnedArray;
    }
}
