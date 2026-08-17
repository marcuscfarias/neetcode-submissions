public class Solution {
    public int Search(int[] nums, int target) {
        
        int low = 0, high = nums.Length - 1;

        while(low <= high){

            int mid = (high + low) / 2;
            int number = nums[mid];

            // Console.WriteLine("Index - Low: {0}, Mid: {1}, High: {2}", low, mid, high);
            // Console.WriteLine("Number - Low: {0}, Mid: {1}, High: {2}", nums[low], number, nums[high]);

            if(target == number){
                return mid;
            }

            if(target > number){
                low = mid + 1;
            }

            if(target < number){
                high = mid - 1;
            }
        }

        return -1;
    }
}
