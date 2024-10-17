using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MaximumAverageSubarray1
{
    public static class Solution
    {
        public static double Solve(int[] nums, int k)
        {
            double max = double.MinValue;

            Queue<int> window = new();
            double total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                window.Enqueue(nums[i]);
                total += nums[i];

                if (window.Count == k)
                {
                    if (max < total / k) max = total / k;
                    total -= window.Dequeue();
                }
            }

            return max;
        }
    }
}
