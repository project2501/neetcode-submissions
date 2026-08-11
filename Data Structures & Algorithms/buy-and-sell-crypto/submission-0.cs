public class Solution {
    public int MaxProfit(int[] prices) {

        int max = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i; j < prices.Length; j++)
            {
                max = Math.Max(prices[j]-prices[i], max);
            }
        }

        return max;
    }
}
