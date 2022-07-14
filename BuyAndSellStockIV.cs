using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class BuyAndSellStockIV
    {
        /*
         * T.C: O(nk) where n is no of prices and k is no of transaction allowed
         * S.C: O(k) no of transaction allowed
         */
        public int MaxProfit(int k, int[] prices)
        {
            if (prices == null || prices.Length == 0 || k == 0) return 0;

            int[] buy = new int[k];
            Array.Fill(buy, int.MaxValue);
            int[] sell = new int[k];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (j > 0)
                    {
                        buy[j] = Math.Min(buy[j], prices[i] - sell[j - 1]);
                    }
                    else
                    {
                        buy[j] = Math.Min(buy[j], prices[i]);
                    }

                    sell[j] = Math.Max(sell[j], prices[i] - buy[j]);
                }
            }

            return sell[k - 1];
        }
    }
}
