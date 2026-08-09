public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dic = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){

            int numValue = nums[i];
            int dif = target - numValue;

            Console.WriteLine("i: {2}, numValue: {0}, dif: {1}", numValue, dif, i);

            if(dic.ContainsKey(dif))
            {
                Console.WriteLine("Essa diferença existe!");
                return new int[] {dic[dif], i};
            }
            else
            {
                Console.WriteLine("Essa diferença NÃO existe!");
                dic.Add(numValue, i);
            }
        }

        return new int[] {0,0};
    }
}
