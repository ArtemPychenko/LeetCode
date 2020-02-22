namespace Arrays.Solution.MaximumProfit
{
    public class MaximumProfit
    {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;

            if (prices.Length < 2)
            {
                return 0;
            }

            for (int i = prices.Length - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    var result = prices[i] - prices[j];
                    if (maxProfit < result)
                    {
                        maxProfit = result;
                    }
                }
            }

            return maxProfit;
        }
    }
}
