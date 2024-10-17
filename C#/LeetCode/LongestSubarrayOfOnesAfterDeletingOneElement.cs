using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LongestSubarrayOfOnesAfterDeletingOneElement
{
    public static class Solution
    {
        public static int Solve(int[] nums)
        {
            int max = 0;

            bool hasZero = false;
            int count = 0;
            int l = 0;
            int r = 0;

            while (r < nums.Length)
            {
                if (nums[r] == 1)
                {
                    count++;
                    r++;
                    if (hasZero == true && count > max) max = count;
                    if (hasZero == false && count - 1 > max) max = count - 1;
                } else
                {
                    if (hasZero == false)
                    {
                        hasZero = true;
                        r++;
                        if (count > max) max = count;
                    } else
                    {
                        while (nums[l] == 1)
                        {
                            l++;
                            count--;
                        }
                        hasZero = false;
                        l++;
                    }
                }
            }

            return max;
        }
    }
}
