using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MergeStringsAlternately
{
    public static class Solution
    {
        public static string Solve(string word1, string word2)
        {
            string output = "";

            for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
            {
                if (i < word1.Length) output += word1[i];
                if (i < word2.Length) output += word2[i];
            }

            return output;
        }
    }
}
