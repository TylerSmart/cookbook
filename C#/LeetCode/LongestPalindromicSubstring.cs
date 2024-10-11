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
            // BRUTE FORCE APPROACH

            if (s.Length <= 1) return s;

            string longest = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    string current = s.Substring(i, j + 1);

                    bool isPalindrome = true;
                    for (int k = 0; k < current.Length / 2; k++)
                    {
                        if (current[k] != current[current.Length - k - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    
                    if (isPalindrome && current.Length > longest.Length) longest = current;
                }
                

            }

            return longest;

        }
    }
}
