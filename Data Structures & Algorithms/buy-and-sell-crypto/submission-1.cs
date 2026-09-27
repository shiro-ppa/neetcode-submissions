public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++) {
            min = Math.Min(min, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - min);
        }
        return maxProfit;
        
    }
}
