public class Solution {
    public int MaxProfit(int[] prices) {
        
        int profit = 0, lowestIndex = 0;

        for(int i = 0; i < prices.Length; i++){

            int current = prices[i];
            int lowest = prices[lowestIndex];

            if(current < lowest){
                lowestIndex = i;
            }else{
                profit = Math.Max(profit, current - lowest);
            }

            // Console.WriteLine("current: {0}, lowest: {1}, profit: {2}", current, prices[lowestIndex], profit);
        }

        return profit;
    }
}
