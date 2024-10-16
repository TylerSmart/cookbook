using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MaxNumberOfKSumPairs
{
    public static class Solution
    {
        public static int Solve(int[] nums, int k)
        {
            Dictionary<int, int> sumMap = new();
            int output = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (sumMap.ContainsKey(k - nums[i]) && sumMap[k - nums[i]] > 0) {
                    sumMap[k - nums[i]]--;
                    output++;
                } else
                {
                    if (sumMap.ContainsKey(nums[i]) == false) sumMap.Add(nums[i], 0);
                    sumMap[nums[i]]++;
                }
            }

            return output;
        }
    }
}
