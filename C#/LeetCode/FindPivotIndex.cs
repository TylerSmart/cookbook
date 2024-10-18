using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FindPivotIndex
{
    public static class Solution
    {
        public static int Solve(int[] nums)
        {
            int rightSum = nums.Sum();
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (rightSum - nums[i] == leftSum) return i;
                rightSum -= nums[i];
                leftSum += nums[i];
            }


            return -1;
        }
    }
}
