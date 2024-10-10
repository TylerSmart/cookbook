using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoSum
{
    public static class Solution
    {
        public static int[] Solve(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return [i, j];
                }
            }

            throw new Exception("Failed to find a solution.");
        }
    }
}
