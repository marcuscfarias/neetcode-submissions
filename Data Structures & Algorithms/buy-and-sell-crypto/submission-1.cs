public class Solution {
    public int MaxProfit(int[] prices) {
        
        int profit = 0;
        int lowestPrice = prices[0];

        for(int i = 1; i < prices.Length; i++){

            int price = prices[i];

            if(price < lowestPrice){
                lowestPrice = price;
            }else{
                profit = Math.Max(profit, price - lowestPrice);
            }

        }

        return profit;
    }
}
