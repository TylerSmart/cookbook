using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ReverseWordsInAString
{
    public static class Solution
    {
        public static string Solve(string s)
        {
            return string.Join(" ", s.Trim().Split(" ").Where(word => word != "").Select(word => word.Trim()).Reverse());
        }
    }
}
