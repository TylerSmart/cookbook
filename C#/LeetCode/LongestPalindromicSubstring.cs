using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LongestPalindromicSubstring
{
    public static class Solution
    {
        public static string Solve(string s)
        {
            string longest = "";

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int maxLen = Math.Max(len1, len2);

                int start = i - (maxLen - 1) / 2;
                int end = i + maxLen / 2;
                string current = s.Substring(start, end - start + 1);

                if (current.Length > longest.Length)
                {
                    longest = current;
                }
            }

            return longest;
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            if (string.IsNullOrEmpty(s) || left > right)
                return 0;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
