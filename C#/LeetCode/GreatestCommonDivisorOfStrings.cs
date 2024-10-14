using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.GreatestCommonDivisorOfStrings
{
    public static class Solution
    {
        public static string Solve(string str1, string str2)
        {
            bool IsValid(string str1, string str2, int k)
            {
                int len1 = str1.Length, len2 = str2.Length;
                if (len1 % k > 0 || len2 % k > 0)
                {
                    return false;
                }
                else
                {
                    string baseStr = str1.Substring(0, k);
                    return string.Concat(Enumerable.Repeat(baseStr, len1 / k)) == str1 && string.Concat(Enumerable.Repeat(baseStr, len2 / k)) == str2;
                }
            }

            int len1 = str1.Length, len2 = str2.Length;
            for (int i = Math.Min(len1, len2); i >= 1; i--)
            {
                if (IsValid(str1, str2, i))
                {
                    return str1.Substring(0, i);
                }
            }
            return "";
        }
    }
}
