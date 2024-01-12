using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Blind_75
{
    public class Two_Sum
    {
        public static void Main()
        {
            Console.WriteLine("Enter array size:");

            int size = Convert.ToInt32(Console.ReadLine());
            /*int[] nums = new int[size];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }*/

            Console.WriteLine("Enter space-separated array elements:");

            string[] inputArray = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(inputArray, int.Parse);

            Console.WriteLine("Enter Target element:");
            int target = Convert.ToInt32(Console.ReadLine());

            int l = 0;
            int r = nums.Length - 1;
            int[] ans = new int[2];
            int flg = 0;
            while (l <= r)
            {
                int sum = nums[l] + nums[r];
                if (sum == target && r > l)
                {
                    ans[0] = l;
                    ans[1] = r;
                    //return ans;
                    flg = 1;
                    break;
                }
                else if (r > l)
                {
                    r--;
                }
                else
                {
                    r = nums.Length - 1;
                    l++;
                }
            }
            //return null
            Console.WriteLine("Expected Output:");

            if (flg==1)
            {
                foreach (int i in ans)
                {
                    Console.Write(i + " ");
                }
            }
            

            Console.ReadLine();
        }
    }
}
