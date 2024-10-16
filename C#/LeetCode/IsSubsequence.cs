using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.IsSubsequence
{
    public static class Solution
    {
        public static bool Solve(string s, string t)
        {
            if (s.Length == 0) return true;

            for (int sIndex = 0, tIndex = 0; sIndex < s.Length && tIndex < t.Length; tIndex++)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;

                    if (sIndex == s.Length) return true;
                }
            }

            return false;
        }
    }
}
