
using System;
using System.Linq;

namespace Arrays.Solution.BuySellStock2
{
    public class BuySellStock2
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1 || prices.Length == 0)
            {
                return 0;
            }

            var left = new int[prices.Length / 2];
            var right = new int[prices.Length - left.Length];

            Array.Copy(prices, 0, left, 0, prices.Length / 2);
            Array.Copy(prices, prices.Length / 2, right, 0, prices.Length - left.Length);

            int leftDifference = MaxProfit(left);
            int rightDifference = MaxProfit(right);
            int diff;

            if (prices.Length == 2)
            {
                return prices[1] - prices[0] < 0 ? 0 : prices[1] - prices[0];
            }

            var midDifference = right[0] - left[left.Length - 1] < 0 ? 0 : right[0] - left[left.Length - 1];

            if (right.Max() - left.Min() > leftDifference + rightDifference + midDifference)
            {
                diff = right.Max() - left.Min();
            }
            else
            {
                diff = leftDifference + rightDifference + midDifference;
            }
            return diff;
        }
    }
}
