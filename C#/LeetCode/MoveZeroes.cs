using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MoveZeroes
{
    public static class Solution
    {
        public static void Solve(int[] nums)
        {
            Queue<int> lastOpen = new();
            int zeroes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroes++;
                    lastOpen.Enqueue(i);
                }
                else
                {

                    if (lastOpen.Count > 0)
                    {
                        nums[lastOpen.Dequeue()] = nums[i];
                        lastOpen.Enqueue(i);
                    }
                }
            }

            for (int i = nums.Length - 1; zeroes > 0; i--)
            {
                nums[i] = 0;
                zeroes--;
            }
        }
    }
}
