using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    /*
     * T.C: O(n) where n is no of prices
     * S.C: O(1) since we are not using any extra space
     */
   public  class BuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;

            int min = int.MaxValue;
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                min = Math.Min(min, prices[i]);
                profit = Math.Max(profit, prices[i] - min);
            }

            return profit;
        }
    }
}
