using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FindTheHighestAltitude
{
    public static class Solution
    {
        public static int Solve(int[] gain)
        {
            int max = 0;
            int current = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                current += gain[i];
                if (current > max) max = current;
            }

            return max;
        }
    }
}
