using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class BuyAndSellStockII
    {
        /*
         * T.C: O(N) : where n is no of prices 
         * S.C: O(1) only variable used and not any data structure
         */
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;

            int buy1 = int.MaxValue;
            int sell1 = 0;
            int buy2 = int.MaxValue;
            int sell2 = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                buy1 = Math.Min(buy1, prices[i]);
                sell1 = Math.Max(sell1, prices[i] - buy1);
                buy2 = Math.Min(buy2, prices[i] - sell1);
                sell2 = Math.Max(sell2, prices[i] - buy2);
            }

            return sell2;
        }
    }
}
