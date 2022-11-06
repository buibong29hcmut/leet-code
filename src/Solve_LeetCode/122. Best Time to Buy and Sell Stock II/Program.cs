public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        for(int i = 0; i < prices.Length-1; i++)
        {
            max = max + prices[i + 1] > prices[i] ? prices[i + 1] - prices[i] : 0;

        }
        return max;
    }
}
