using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MaximumNumberOfVowelsInASubstringOfGivenLength
{
    public static class Solution
    {
        public static int Solve(string s, int k)
        {
            char[] VOWELS = ['a', 'e', 'i', 'o', 'u'];

            int max = 0;

            Queue<char> window = new Queue<char>();
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                window.Enqueue(s[i]);
                if (VOWELS.Contains(s[i])) total++;

                if (window.Count == k)
                {
                    if (total > max) max = total;
                    if (total == k) return total;

                    if (VOWELS.Contains(window.Dequeue())) total--;
                }
            }

            return max;
        }
    }
}
