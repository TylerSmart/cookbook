using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.IncreasingTripletSubsequence
{
    public static class Solution
    {
        public static bool Solve(int[] nums)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] <= first)
                {
                    first = nums[i];
                }
                else if (nums[i] <= second)
                {
                    second = nums[i];
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        
    }
}
