using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Blind_75
{
    public class _4_Product_of_Array_Except_Self
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(inputArray, int.Parse);
            int[] res = new int[nums.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = 1;
            }
            int prefix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = prefix;
                prefix *= nums[i];
            }
            int postfix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] *= postfix;
                postfix *= nums[i];
            }

            //return res;

            foreach(int i in res)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
