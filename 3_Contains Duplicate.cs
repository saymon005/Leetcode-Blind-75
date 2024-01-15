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
            Console.WriteLine("Enter Size: ");
            int size = Convert.ToInt32(Console.ReadLine()); 
            //int[] nums = new int[size];
            /*for (int i=0; i<size; i++)
            {
                nums[i] = Convert.ToInt32(Console.Read());
            }*/
            string[] inputArray = Console.ReadLine().Split(' ');
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
