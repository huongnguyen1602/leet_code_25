using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.LeetCode
{
    internal class ex0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (dict.ContainsKey(temp))
                {
                    return new int[] { dict[temp], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }

}
