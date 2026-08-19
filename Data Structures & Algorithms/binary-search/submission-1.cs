public class Solution {
    public int Search(int[] nums, int target) {
        
        int low = 0;
        int high = nums.Length - 1;

        while(low <= high){

            int mid = low + (high-low)/2;
            int num = nums[mid];

            // Console.WriteLine("low: {0}, high: {1}", low, high);
            // Console.WriteLine("mid: {0}, numero: {1}", mid, num);

            if(target == num){
                return mid;
            }

            if(target > num){
                low = mid + 1;
            }

            if(target < num){
                high = mid - 1;
            }
        }

        return -1;
    }
}
