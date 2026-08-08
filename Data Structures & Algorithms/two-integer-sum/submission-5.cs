public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int dif = target - nums[i];

            if (seen.TryGetValue(dif, out int j))  // j é o valor que já passou
                return new[] { j, i };

            seen[nums[i]] = i; // indexador em vez de Add, não lança em duplicata
        }

        return Array.Empty<int>();
    }
}
