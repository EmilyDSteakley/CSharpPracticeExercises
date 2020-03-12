using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class LC_A_BestTimeToBuyAndSellStock
    {
        // ---------------------------------------- Problem ----------------------------------------

        // 121. Best Time to Buy and Sell Stock

        // Say you have an array for which the ith element is the price of a given stock on day i.

        // If you were only permitted to complete at most one transaction
        // (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

        // Note that you cannot sell a stock before you buy one.

        // Example 1:
        // Input: [7,1,5,3,6,4]
        // Output: 5
        // Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //              Not 7-1 = 6, as selling price needs to be larger than buying price.

        // Example 2:
        // Input: [7,6,4,3,1]
        // Output: 0
        // Explanation: In this case, no transaction is done, i.e.max profit = 0.



        // ---------------------------------------- My Solution ----------------------------------------
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0 || prices.Length == 1)
                return 0;

            var maxProfit = 0;
            var maxPrice = 0;
            var maxIdx = 0;
            var start = 0;

            (maxPrice, maxIdx) = max(prices, start);
            while (true)
            {
                for (int i = start; i < maxIdx; i++)
                {
                    if (maxPrice - prices[i] > maxProfit)
                        maxProfit = maxPrice - prices[i];
                }
                if (maxIdx == prices.Length - 1)
                    break;
                start = maxIdx + 1;
                (maxPrice, maxIdx) = max(prices, start);
            }

            return maxProfit;
        }

        public (int, int) max(int[] arr, int start)
        {
            var max = arr[start];
            var maxIdx = start;
            for (int i = start; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIdx = i;
                }
            }
            return (max, maxIdx);
        }
        // 708 ms <-- Beats 18.64%
        // Solved March 11, 2020



        public int MaxProfit3(int[] prices)
        {
            if (prices.Length == 0 || prices.Length == 1)
                return 0;

            var profit = 0;
            var maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                profit = max3(prices, i) - prices[i];
                if (profit > maxProfit)
                    maxProfit = profit;
            }
            return maxProfit;
        }

        public int max3(int[] arr, int start)
        {
            var max = arr[start];
            for (int i = start; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        // 676 ms <-- Beats 18.82%
        // Solved March 11, 2020



        // ---------------------------------------- 96 ms Solution on LeetCode ----------------------------------------
        public int MaxProfit96(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int price = Int32.MaxValue;
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < price)
                {
                    price = prices[i];
                }
                else
                {
                    int temp_profit = prices[i] - price;
                    if (temp_profit > profit)
                    {
                        profit = temp_profit;
                    }
                }
            }

            return profit;
        }



        // ---------------------------------------- 76 ms Solution on LeetCode ----------------------------------------
        public int MaxProfit76(int[] prices)
        {
            var maxProfit = 0;
            if (prices.Length <= 1)
            {
                return maxProfit;
            }
            var curMin = prices[0];
            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < curMin)
                {
                    curMin = prices[i];
                }
                else
                {
                    maxProfit = prices[i] - curMin > maxProfit ? prices[i] - curMin : maxProfit;
                }
            }
            return maxProfit;
        }

    } // LC_A_BestTimeToBuyAndSellStock class

} // CSharpPracticeExercises namespace
