using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Blind_75
{
    public class _3_Contains_Duplicate
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine()); 
            string[] inputArray = new string[size];
            int[] nums = Array.ConvertAll(inputArray, int.Parse);
            HashSet<int> s = new HashSet<int>();
            for(int i=0; i< nums.Length; i++)
            {
                s.Add(nums[i]);
            }

            if(s.Count == nums.Length)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
