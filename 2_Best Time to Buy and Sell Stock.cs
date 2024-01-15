using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Blind_75
{
    public class _2_Best_Time_to_Buy_and_Sell_Stock
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] prices = Array.ConvertAll(inputArray, int.Parse);
            int mxProfit = 0;
            int minPrice = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                int profit = Math.Abs(prices[i] - minPrice);
                mxProfit = Math.Max(profit, mxProfit);
            }

            Console.WriteLine(mxProfit);
            Console.ReadLine();
        }
    }
}
