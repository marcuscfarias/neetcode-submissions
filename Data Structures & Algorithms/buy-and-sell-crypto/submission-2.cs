public class Solution {
    public int MaxProfit(int[] prices) {
        
        int profit = 0, lowestIndex = 0;

        for(int i = 0; i < prices.Length; i++){

            int current = prices[i];
            int lowestNumber = prices[lowestIndex];

            if(current < lowestNumber){
                lowestIndex = i;
            }else{
                profit = Math.Max(profit, current - lowestNumber);
            }
        }

        return profit;
    }
}
